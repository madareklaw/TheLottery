namespace TheLottery
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.WinningNumbersLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RandomNumbersBtn = new System.Windows.Forms.Button();
            this.PlayUntilWinCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(34, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(198, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(34, 20);
            this.textBox5.TabIndex = 4;
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(6, 39);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(136, 13);
            this.results.TabIndex = 5;
            this.results.Text = "Type some numbers to play";
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(12, 155);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(359, 61);
            this.playBtn.TabIndex = 6;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // WinningNumbersLable
            // 
            this.WinningNumbersLable.AutoSize = true;
            this.WinningNumbersLable.Location = new System.Drawing.Point(6, 16);
            this.WinningNumbersLable.Name = "WinningNumbersLable";
            this.WinningNumbersLable.Size = new System.Drawing.Size(35, 13);
            this.WinningNumbersLable.TabIndex = 7;
            this.WinningNumbersLable.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your numbers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WinningNumbersLable);
            this.groupBox2.Controls.Add(this.results);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Winning numbers";
            // 
            // RandomNumbersBtn
            // 
            this.RandomNumbersBtn.Location = new System.Drawing.Point(284, 22);
            this.RandomNumbersBtn.Name = "RandomNumbersBtn";
            this.RandomNumbersBtn.Size = new System.Drawing.Size(87, 36);
            this.RandomNumbersBtn.TabIndex = 10;
            this.RandomNumbersBtn.Text = "RND";
            this.RandomNumbersBtn.UseVisualStyleBackColor = true;
            this.RandomNumbersBtn.Click += new System.EventHandler(this.RandomNumbersBtn_Click);
            // 
            // PlayUntilWinCheckBox
            // 
            this.PlayUntilWinCheckBox.AutoSize = true;
            this.PlayUntilWinCheckBox.Location = new System.Drawing.Point(284, 104);
            this.PlayUntilWinCheckBox.Name = "PlayUntilWinCheckBox";
            this.PlayUntilWinCheckBox.Size = new System.Drawing.Size(87, 17);
            this.PlayUntilWinCheckBox.TabIndex = 11;
            this.PlayUntilWinCheckBox.Text = "Play until win";
            this.PlayUntilWinCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 227);
            this.Controls.Add(this.PlayUntilWinCheckBox);
            this.Controls.Add(this.RandomNumbersBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Lottery";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label WinningNumbersLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RandomNumbersBtn;
        private System.Windows.Forms.CheckBox PlayUntilWinCheckBox;
    }
}

