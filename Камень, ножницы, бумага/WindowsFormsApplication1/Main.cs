using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            Game game_form = new Game(1, byte.Parse(comboBox1.Text));
            game_form.Show();
        }

        private void button_demo_Click(object sender, EventArgs e)
        {
            Game game_form = new Game(2, byte.Parse(comboBox1.Text));
            game_form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prm.s = comboBox1.Text;
            if (prm.s == Clipboard.GetText())
            {
                MessageBox.Show("don't copypaste", "", MessageBoxButtons.OK);
                comboBox1.Items.Clear();
                return;
            }
        }
    }
}
