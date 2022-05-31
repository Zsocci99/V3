namespace V3
{
    partial class WinNewGame
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
            this.labPlayer1 = new System.Windows.Forms.Label();
            this.labPlayer2 = new System.Windows.Forms.Label();
            this.labPlayer3 = new System.Windows.Forms.Label();
            this.labPlayer4 = new System.Windows.Forms.Label();
            this.labPlayer5 = new System.Windows.Forms.Label();
            this.teBoPlayerName1 = new System.Windows.Forms.TextBox();
            this.teBoPlayerName2 = new System.Windows.Forms.TextBox();
            this.teBoPlayerName3 = new System.Windows.Forms.TextBox();
            this.teBoPlayerName4 = new System.Windows.Forms.TextBox();
            this.teBoPlayerName5 = new System.Windows.Forms.TextBox();
            this.butBack = new System.Windows.Forms.Button();
            this.butGameStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labPlayer1
            // 
            this.labPlayer1.AutoSize = true;
            this.labPlayer1.Location = new System.Drawing.Point(12, 12);
            this.labPlayer1.Name = "labPlayer1";
            this.labPlayer1.Size = new System.Drawing.Size(56, 13);
            this.labPlayer1.TabIndex = 0;
            this.labPlayer1.Text = "Játékos 1:";
            // 
            // labPlayer2
            // 
            this.labPlayer2.AutoSize = true;
            this.labPlayer2.Location = new System.Drawing.Point(12, 38);
            this.labPlayer2.Name = "labPlayer2";
            this.labPlayer2.Size = new System.Drawing.Size(56, 13);
            this.labPlayer2.TabIndex = 1;
            this.labPlayer2.Text = "Játékos 2:";
            // 
            // labPlayer3
            // 
            this.labPlayer3.AutoSize = true;
            this.labPlayer3.Location = new System.Drawing.Point(12, 64);
            this.labPlayer3.Name = "labPlayer3";
            this.labPlayer3.Size = new System.Drawing.Size(56, 13);
            this.labPlayer3.TabIndex = 2;
            this.labPlayer3.Text = "Játékos 3:";
            // 
            // labPlayer4
            // 
            this.labPlayer4.AutoSize = true;
            this.labPlayer4.Location = new System.Drawing.Point(12, 90);
            this.labPlayer4.Name = "labPlayer4";
            this.labPlayer4.Size = new System.Drawing.Size(56, 13);
            this.labPlayer4.TabIndex = 3;
            this.labPlayer4.Text = "Játékos 4:";
            // 
            // labPlayer5
            // 
            this.labPlayer5.AutoSize = true;
            this.labPlayer5.Location = new System.Drawing.Point(12, 116);
            this.labPlayer5.Name = "labPlayer5";
            this.labPlayer5.Size = new System.Drawing.Size(56, 13);
            this.labPlayer5.TabIndex = 4;
            this.labPlayer5.Text = "Játékos 5:";
            // 
            // teBoPlayerName1
            // 
            this.teBoPlayerName1.Location = new System.Drawing.Point(84, 12);
            this.teBoPlayerName1.Name = "teBoPlayerName1";
            this.teBoPlayerName1.Size = new System.Drawing.Size(100, 20);
            this.teBoPlayerName1.TabIndex = 5;
            this.teBoPlayerName1.TextChanged += new System.EventHandler(this.teBoPlayerName1_TextChanged);
            // 
            // teBoPlayerName2
            // 
            this.teBoPlayerName2.Location = new System.Drawing.Point(84, 38);
            this.teBoPlayerName2.Name = "teBoPlayerName2";
            this.teBoPlayerName2.Size = new System.Drawing.Size(100, 20);
            this.teBoPlayerName2.TabIndex = 6;
            this.teBoPlayerName2.TextChanged += new System.EventHandler(this.teBoPlayerName2_TextChanged);
            // 
            // teBoPlayerName3
            // 
            this.teBoPlayerName3.Location = new System.Drawing.Point(84, 64);
            this.teBoPlayerName3.Name = "teBoPlayerName3";
            this.teBoPlayerName3.Size = new System.Drawing.Size(100, 20);
            this.teBoPlayerName3.TabIndex = 7;
            this.teBoPlayerName3.TextChanged += new System.EventHandler(this.teBoPlayerName3_TextChanged);
            // 
            // teBoPlayerName4
            // 
            this.teBoPlayerName4.Location = new System.Drawing.Point(84, 90);
            this.teBoPlayerName4.Name = "teBoPlayerName4";
            this.teBoPlayerName4.Size = new System.Drawing.Size(100, 20);
            this.teBoPlayerName4.TabIndex = 8;
            this.teBoPlayerName4.TextChanged += new System.EventHandler(this.teBoPlayerName4_TextChanged);
            // 
            // teBoPlayerName5
            // 
            this.teBoPlayerName5.Location = new System.Drawing.Point(84, 116);
            this.teBoPlayerName5.Name = "teBoPlayerName5";
            this.teBoPlayerName5.Size = new System.Drawing.Size(100, 20);
            this.teBoPlayerName5.TabIndex = 9;
            this.teBoPlayerName5.TextChanged += new System.EventHandler(this.teBoPlayerName5_TextChanged);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(109, 38);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 10;
            this.butBack.Text = "Vissza";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butGameStart
            // 
            this.butGameStart.Location = new System.Drawing.Point(12, 38);
            this.butGameStart.Name = "butGameStart";
            this.butGameStart.Size = new System.Drawing.Size(88, 23);
            this.butGameStart.TabIndex = 11;
            this.butGameStart.Text = "Játék Indítása";
            this.butGameStart.UseVisualStyleBackColor = true;
            this.butGameStart.Click += new System.EventHandler(this.butGameStart_Click);
            // 
            // WinNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 180);
            this.Controls.Add(this.butGameStart);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.teBoPlayerName5);
            this.Controls.Add(this.teBoPlayerName4);
            this.Controls.Add(this.teBoPlayerName3);
            this.Controls.Add(this.teBoPlayerName2);
            this.Controls.Add(this.teBoPlayerName1);
            this.Controls.Add(this.labPlayer5);
            this.Controls.Add(this.labPlayer4);
            this.Controls.Add(this.labPlayer3);
            this.Controls.Add(this.labPlayer2);
            this.Controls.Add(this.labPlayer1);
            this.Name = "WinNewGame";
            this.Text = "WinNewGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinNewGame_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPlayer1;
        private System.Windows.Forms.Label labPlayer2;
        private System.Windows.Forms.Label labPlayer3;
        private System.Windows.Forms.Label labPlayer4;
        private System.Windows.Forms.Label labPlayer5;
        private System.Windows.Forms.TextBox teBoPlayerName1;
        private System.Windows.Forms.TextBox teBoPlayerName2;
        private System.Windows.Forms.TextBox teBoPlayerName3;
        private System.Windows.Forms.TextBox teBoPlayerName4;
        private System.Windows.Forms.TextBox teBoPlayerName5;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butGameStart;
    }
}