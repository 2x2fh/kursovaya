namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_play = new System.Windows.Forms.Button();
            this.button_demo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(12, 43);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(242, 36);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "Играть";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_demo
            // 
            this.button_demo.Location = new System.Drawing.Point(12, 85);
            this.button_demo.Name = "button_demo";
            this.button_demo.Size = new System.Drawing.Size(242, 36);
            this.button_demo.TabIndex = 1;
            this.button_demo.Text = "Демо";
            this.button_demo.UseVisualStyleBackColor = true;
            this.button_demo.Click += new System.EventHandler(this.button_demo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(117, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Очков";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 127);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(242, 36);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 175);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_demo);
            this.Controls.Add(this.button_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Камень, ножицы, бумага";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_demo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
    }
}

