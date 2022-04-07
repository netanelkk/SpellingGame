namespace SpellingGame
{
    partial class GamesMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.close_games = new System.Windows.Forms.Button();
            this.open_typing = new System.Windows.Forms.PictureBox();
            this.open_memory = new System.Windows.Forms.PictureBox();
            this.open_findwords = new System.Windows.Forms.PictureBox();
            this.open_ctw = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.open_typing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_findwords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_ctw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Lupa Planta", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playground";
            // 
            // close_games
            // 
            this.close_games.BackColor = System.Drawing.Color.DarkSalmon;
            this.close_games.Location = new System.Drawing.Point(423, 418);
            this.close_games.Name = "close_games";
            this.close_games.Size = new System.Drawing.Size(174, 31);
            this.close_games.TabIndex = 2;
            this.close_games.Text = "Back To Menu";
            this.close_games.UseVisualStyleBackColor = false;
            this.close_games.Click += new System.EventHandler(this.close_games_Click);
            // 
            // open_typing
            // 
            this.open_typing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_typing.Image = global::SpellingGame.Properties.Resources.typinggame_icon;
            this.open_typing.Location = new System.Drawing.Point(12, 123);
            this.open_typing.Name = "open_typing";
            this.open_typing.Size = new System.Drawing.Size(228, 215);
            this.open_typing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open_typing.TabIndex = 4;
            this.open_typing.TabStop = false;
            this.open_typing.Click += new System.EventHandler(this.open_typing_Click);
            // 
            // open_memory
            // 
            this.open_memory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_memory.Image = global::SpellingGame.Properties.Resources.memorygame_icon;
            this.open_memory.Location = new System.Drawing.Point(263, 123);
            this.open_memory.Name = "open_memory";
            this.open_memory.Size = new System.Drawing.Size(228, 215);
            this.open_memory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open_memory.TabIndex = 5;
            this.open_memory.TabStop = false;
            this.open_memory.Click += new System.EventHandler(this.open_memory_Click);
            // 
            // open_findwords
            // 
            this.open_findwords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_findwords.Image = global::SpellingGame.Properties.Resources.wordsbeginningwith_icon;
            this.open_findwords.Location = new System.Drawing.Point(510, 123);
            this.open_findwords.Name = "open_findwords";
            this.open_findwords.Size = new System.Drawing.Size(228, 215);
            this.open_findwords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open_findwords.TabIndex = 6;
            this.open_findwords.TabStop = false;
            this.open_findwords.Click += new System.EventHandler(this.open_findwords_Click);
            // 
            // open_ctw
            // 
            this.open_ctw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_ctw.Image = global::SpellingGame.Properties.Resources.completetheword_icon;
            this.open_ctw.Location = new System.Drawing.Point(744, 123);
            this.open_ctw.Name = "open_ctw";
            this.open_ctw.Size = new System.Drawing.Size(228, 215);
            this.open_ctw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open_ctw.TabIndex = 7;
            this.open_ctw.TabStop = false;
            this.open_ctw.Click += new System.EventHandler(this.open_ctw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(49, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Typing Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(292, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Memory Game";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(529, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Find Words Beginning With";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(755, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Complete The Word";
            // 
            // GamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpellingGame.Properties.Resources.cartoon_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.open_ctw);
            this.Controls.Add(this.open_findwords);
            this.Controls.Add(this.open_memory);
            this.Controls.Add(this.open_typing);
            this.Controls.Add(this.close_games);
            this.Controls.Add(this.label1);
            this.Name = "GamesMenu";
            this.Text = "Games Menu";
            ((System.ComponentModel.ISupportInitialize)(this.open_typing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_findwords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_ctw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_games;
        private System.Windows.Forms.PictureBox open_typing;
        private System.Windows.Forms.PictureBox open_memory;
        private System.Windows.Forms.PictureBox open_findwords;
        private System.Windows.Forms.PictureBox open_ctw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}