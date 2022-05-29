namespace V3
{
    partial class WinMainMenu
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
            this.butNewGame = new System.Windows.Forms.Button();
            this.butTotirial = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butNewGame
            // 
            this.butNewGame.Location = new System.Drawing.Point(12, 12);
            this.butNewGame.Name = "butNewGame";
            this.butNewGame.Size = new System.Drawing.Size(243, 49);
            this.butNewGame.TabIndex = 0;
            this.butNewGame.Text = "Új játék indítása";
            this.butNewGame.UseVisualStyleBackColor = true;
            this.butNewGame.Click += new System.EventHandler(this.butNewGame_Click);
            // 
            // butTotirial
            // 
            this.butTotirial.Location = new System.Drawing.Point(12, 76);
            this.butTotirial.Name = "butTotirial";
            this.butTotirial.Size = new System.Drawing.Size(243, 49);
            this.butTotirial.TabIndex = 1;
            this.butTotirial.Text = "Tutorial";
            this.butTotirial.UseVisualStyleBackColor = true;
            this.butTotirial.Click += new System.EventHandler(this.butTotirial_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(12, 143);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(243, 49);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "Kilépés";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // WinMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 220);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butTotirial);
            this.Controls.Add(this.butNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinMainMenu";
            this.Text = "Főmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butNewGame;
        private System.Windows.Forms.Button butTotirial;
        private System.Windows.Forms.Button butExit;
    }
}

