namespace WindowsFormsApplication1
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Log = new System.Windows.Forms.TextBox();
            this.button_save_log = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.score_pc_text = new System.Windows.Forms.Label();
            this.score_player_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.action_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paper_pic = new System.Windows.Forms.PictureBox();
            this.scissors_pic = new System.Windows.Forms.PictureBox();
            this.rock_pic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(481, 1);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(246, 306);
            this.Log.TabIndex = 0;
            this.Log.TextChanged += new System.EventHandler(this.Log_TextChanged);
            // 
            // button_save_log
            // 
            this.button_save_log.Location = new System.Drawing.Point(481, 307);
            this.button_save_log.Name = "button_save_log";
            this.button_save_log.Size = new System.Drawing.Size(247, 22);
            this.button_save_log.TabIndex = 1;
            this.button_save_log.Text = "Сохранить";
            this.button_save_log.UseVisualStyleBackColor = true;
            this.button_save_log.Click += new System.EventHandler(this.button_save_log_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.score_pc_text);
            this.panel1.Controls.Add(this.score_player_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.action_text);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.paper_pic);
            this.panel1.Controls.Add(this.scissors_pic);
            this.panel1.Controls.Add(this.rock_pic);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 328);
            this.panel1.TabIndex = 2;
            // 
            // score_pc_text
            // 
            this.score_pc_text.AutoSize = true;
            this.score_pc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_pc_text.Location = new System.Drawing.Point(391, 107);
            this.score_pc_text.Name = "score_pc_text";
            this.score_pc_text.Size = new System.Drawing.Size(29, 31);
            this.score_pc_text.TabIndex = 9;
            this.score_pc_text.Text = "0";
            // 
            // score_player_text
            // 
            this.score_player_text.AutoSize = true;
            this.score_player_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_player_text.Location = new System.Drawing.Point(64, 107);
            this.score_player_text.Name = "score_player_text";
            this.score_player_text.Size = new System.Drawing.Size(29, 31);
            this.score_player_text.TabIndex = 8;
            this.score_player_text.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Раунд 1";
            // 
            // action_text
            // 
            this.action_text.AutoSize = true;
            this.action_text.Location = new System.Drawing.Point(191, 189);
            this.action_text.Name = "action_text";
            this.action_text.Size = new System.Drawing.Size(95, 13);
            this.action_text.TabIndex = 6;
            this.action_text.Text = "Выберете фигуру";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(221, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "VS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(286, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // paper_pic
            // 
            this.paper_pic.Image = global::WindowsFormsApplication1.Properties.Resources.Бумага;
            this.paper_pic.Location = new System.Drawing.Point(303, 229);
            this.paper_pic.Name = "paper_pic";
            this.paper_pic.Size = new System.Drawing.Size(96, 96);
            this.paper_pic.TabIndex = 2;
            this.paper_pic.TabStop = false;
            this.paper_pic.Click += new System.EventHandler(this.paper_pic_Click);
            // 
            // scissors_pic
            // 
            this.scissors_pic.Image = global::WindowsFormsApplication1.Properties.Resources.Ножницы;
            this.scissors_pic.Location = new System.Drawing.Point(194, 229);
            this.scissors_pic.Name = "scissors_pic";
            this.scissors_pic.Size = new System.Drawing.Size(96, 96);
            this.scissors_pic.TabIndex = 1;
            this.scissors_pic.TabStop = false;
            this.scissors_pic.Click += new System.EventHandler(this.scissors_pic_Click);
            // 
            // rock_pic
            // 
            this.rock_pic.Image = global::WindowsFormsApplication1.Properties.Resources.Камень;
            this.rock_pic.Location = new System.Drawing.Point(85, 229);
            this.rock_pic.Name = "rock_pic";
            this.rock_pic.Size = new System.Drawing.Size(96, 96);
            this.rock_pic.TabIndex = 0;
            this.rock_pic.TabStop = false;
            this.rock_pic.Click += new System.EventHandler(this.rock_pic_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Ticks);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_save_log);
            this.Controls.Add(this.Log);
            this.Name = "Game";
            this.Text = "Игра";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button button_save_log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label action_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox paper_pic;
        private System.Windows.Forms.PictureBox scissors_pic;
        private System.Windows.Forms.PictureBox rock_pic;
        private System.Windows.Forms.Label score_pc_text;
        private System.Windows.Forms.Label score_player_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}