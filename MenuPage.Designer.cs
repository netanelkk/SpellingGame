namespace SpellingGame
{
    partial class MenuPage
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
            this.quit = new System.Windows.Forms.Button();
            this.LearnSpelling = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayGames = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddContent = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LearnSpelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContent)).BeginInit();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quit.Location = new System.Drawing.Point(439, 12);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(100, 35);
            this.quit.TabIndex = 3;
            this.quit.Text = "QUIT";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // LearnSpelling
            // 
            this.LearnSpelling.BackColor = System.Drawing.Color.Transparent;
            this.LearnSpelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LearnSpelling.Image = global::SpellingGame.Properties.Resources.spelling_page;
            this.LearnSpelling.Location = new System.Drawing.Point(675, 267);
            this.LearnSpelling.Name = "LearnSpelling";
            this.LearnSpelling.Size = new System.Drawing.Size(243, 137);
            this.LearnSpelling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LearnSpelling.TabIndex = 4;
            this.LearnSpelling.TabStop = false;
            this.LearnSpelling.Click += new System.EventHandler(this.LearnSpelling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lemon", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(680, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Learn Spelling";
            // 
            // PlayGames
            // 
            this.PlayGames.BackColor = System.Drawing.Color.Transparent;
            this.PlayGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayGames.Image = global::SpellingGame.Properties.Resources.games_page;
            this.PlayGames.Location = new System.Drawing.Point(376, 267);
            this.PlayGames.Name = "PlayGames";
            this.PlayGames.Size = new System.Drawing.Size(237, 137);
            this.PlayGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayGames.TabIndex = 6;
            this.PlayGames.TabStop = false;
            this.PlayGames.Click += new System.EventHandler(this.PlayGames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lemon", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(395, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Play Games";
            // 
            // AddContent
            // 
            this.AddContent.BackColor = System.Drawing.Color.Transparent;
            this.AddContent.BackgroundImage = global::SpellingGame.Properties.Resources.addcontent_page;
            this.AddContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddContent.Location = new System.Drawing.Point(56, 267);
            this.AddContent.Name = "AddContent";
            this.AddContent.Size = new System.Drawing.Size(220, 137);
            this.AddContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddContent.TabIndex = 8;
            this.AddContent.TabStop = false;
            this.AddContent.Click += new System.EventHandler(this.AddContent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lemon", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(72, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kalam", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(376, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "What Would You";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kalam", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(357, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 46);
            this.label5.TabIndex = 11;
            this.label5.Text = "Like To Do Today?";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpellingGame.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LearnSpelling);
            this.Controls.Add(this.quit);
            this.Name = "MenuPage";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LearnSpelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.PictureBox LearnSpelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PlayGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox AddContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}