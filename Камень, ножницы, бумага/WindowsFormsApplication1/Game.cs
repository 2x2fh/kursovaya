using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Game : Form
    {
        int score_1, score_2, round, rounds, p1, p2;
        /*
         score_1\2 - очки игрока 1\2
         round - текущий раунд
         rounds - максимальное количество очков
         p1\2 - фигура игрока 1\2 в текущем раунде
        */


        //Конструктор без параметров
        public Game()
        {
            InitializeComponent();
        }

        //Конструктор с параметрами
        public Game(byte md, byte rnd)
        {
            InitializeComponent();
            round = 0;
            rounds = rnd;
            if (md == 1)
            {
                Log.AppendText(DateTime.Today.ToString("dd.MM.yyyy"));
                Log.Text += Environment.NewLine + Environment.NewLine;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Начата новая игра");
                Log.Text += Environment.NewLine;
            }
            else
            {
                rock_pic.Enabled = false;
                scissors_pic.Enabled = false;
                paper_pic.Enabled = false;
                Log.AppendText(DateTime.Today.ToString("dd.MM.yyyy"));
                Log.Text += Environment.NewLine + Environment.NewLine;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Начата демонстрационная игра");
                Log.Text += Environment.NewLine;
                timer1.Interval = 2000;
                timer1.Enabled = true;
            }

        }

        //Выбор игроком камня
        private void rock_pic_Click(object sender, EventArgs e)
        {
            Player(1);
        }

        //Выбор игроком ножниц
        private void scissors_pic_Click(object sender, EventArgs e)
        {
            Player(2);
        }

        //Выбор игроком бумаги
        private void paper_pic_Click(object sender, EventArgs e)
        {
            Player(3);
        }

        private void timer1_Ticks(object sender, EventArgs e)
        {
            Demo();
        }

        //Сохранение сессии игры в файл
        private void button_save_log_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.Title = "Сохранить";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;
                System.IO.File.WriteAllText(filename, Log.Text);
            }
        }

        private void Log_TextChanged(object sender, EventArgs e)
        {

        }

        //Режим игры человек-компьютер
        public void Player(int figure)
        {
            round++;
            label2.Text = "Раунд " + round.ToString();

            //Выбор фигуры компьютером
            Random rnd = new Random();
            p2 = rnd.Next(1, 4);

            Log.Text += Environment.NewLine;
            Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Рануд " + round);
            Log.Text += Environment.NewLine;

            p1 = figure;
            Figure_change();

            switch (Round_win())
            {
                case 0:
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Ничья");
                    Log.Text += Environment.NewLine;
                    break;
                case 1:
                    score_1++;
                    score_player_text.Text = score_1.ToString();
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Раунд за игроком 1");
                    Log.Text += Environment.NewLine;
                    break;
                case 2:
                    score_2++;
                    score_pc_text.Text = score_2.ToString();
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Раунд за игроком 2");
                    Log.Text += Environment.NewLine;
                    break;
            }

            if (Who_win(score_1, score_2) == 1 || Who_win(score_1, score_2) == 2)
            {
                Log.Text += Environment.NewLine;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Победил игрок " + Who_win(score_1, score_2).ToString() + " со счетом "+ score_1 + "-" + score_2);
                Log.Text += Environment.NewLine;
                MessageBox.Show("Победил игрок " + Who_win(score_1, score_2).ToString());

                DialogResult result = MessageBox.Show("Начать новую игру?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    score_1 = 0;
                    score_2 = 0;
                    round = 0;
                    score_player_text.Text = "";
                    score_pc_text.Text = "";
                    label2.Text = "Раунд 1";
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;

                    Log.Text +=  "--------------------------" + Environment.NewLine;
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Начата новая игра");
                    Log.Text += Environment.NewLine;

                }
                else
                    panel1.Enabled = false;
            }

        }

        //Режим игры компьютер-компьютер
        public void Demo()
        {
            round++;
            label2.Text = "Раунд " + round.ToString();
            Log.Text += Environment.NewLine;
            Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Рануд " + round);
            Log.Text += Environment.NewLine;

            //Выбор фигуры компьютером
            Random rnd = new Random();
            p1 = rnd.Next(1, 3);
            p2 = rnd.Next(1, 3);

            Figure_change();

            switch (Round_win())
            {
                case 0:
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Ничья");
                    Log.Text += Environment.NewLine;
                    break;
                case 1:
                    score_1++;
                    score_player_text.Text = score_1.ToString();
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Раунд за игроком 1");
                    Log.Text += Environment.NewLine;
                    break;
                case 2:
                    score_2++;
                    score_pc_text.Text = score_2.ToString();
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Раунд за игроком 2");
                    Log.Text += Environment.NewLine;
                    break;
            }
            
            if (Who_win(score_1, score_2) > 0)
            {
                timer1.Enabled = false;
                Log.Text += Environment.NewLine;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Победил игрок " + Who_win(score_1, score_2).ToString() + " со счетом " + score_1 + "-" + score_2);
                Log.Text += Environment.NewLine;
                MessageBox.Show("Победил игрок " + Who_win(score_1, score_2).ToString());

                DialogResult result = MessageBox.Show("Повторить демо?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    score_1 = 0;
                    score_2 = 0;
                    round = 0;
                    score_player_text.Text = "";
                    score_pc_text.Text = "";
                    label2.Text = "Раунд 1";
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    timer1.Enabled = true;

                    Log.Text += "--------------------------" + Environment.NewLine;
                    Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Начата новая игра");
                    Log.Text += Environment.NewLine;
                }
                else
                {
                    panel1.Enabled = false;
                }
            }
        }

        public void Figure_change()
        {
            if (p1 == 1)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Камень;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Игрок 1 бросает камень");
                Log.Text += Environment.NewLine;
            }
            if (p1 == 2)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Ножницы;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Игрок 1 бросает ножницы");
                Log.Text += Environment.NewLine;
            }

            if (p1 == 3)
            {
                pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Бумага;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Игрок 1 бросает бумагу");
                Log.Text += Environment.NewLine;
            }

            if (p2 == 1)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Камень;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Игрок 2 бросает камень");
                Log.Text += Environment.NewLine;
            }
            if (p2 == 2)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Ножницы;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Игрок 2 бросает ножницы");
                Log.Text += Environment.NewLine;
            }
            if (p2 == 3)
            {
                pictureBox2.Image = WindowsFormsApplication1.Properties.Resources.Бумага;
                Log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": Игрок 2 бросает бумагу");
                Log.Text += Environment.NewLine;
            }
        }

        //Определение победителя раунда
        public int Round_win()
        {
            switch (p1)
            {
                case 1:
                    if (p2 == 1) return 0;
                    if (p2 == 2) return 1;
                    if (p2 == 3) return 2;
                    break;
                case 2:
                    if (p2 == 1) return 2;
                    if (p2 == 2) return 0;
                    if (p2 == 3) return 1;
                    break;
                case 3:
                    if (p2 == 1) return 1;
                    if (p2 == 2) return 2;
                    if (p2 == 3) return 0;
                    break;
                default: return 0;
            }
            return 0;
        }
        //Определение победителя игры
        public int Who_win(int sc1,int sc2)
        {
            switch (rounds)
            {
                case 1: if (sc1 == 1) return 1; else if (sc2 == 1) return 2; else return 0;
                case 3: if (sc1 == 2) return 1; else if (sc2 == 2) return 2; else return 0;
                case 5: if (sc1 == 3) return 1; else if (sc2 == 3) return 2; else return 0;
                case 7: if (sc1 == 4) return 1; else if (sc2 == 4) return 2; else return 0;
                case 9: if (sc1 == 5) return 1; else if (sc2 == 5) return 2; else return 0;
                default: return 0;
            }
        }
    }
}
