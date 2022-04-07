namespace SpellingGame
{
    partial class SpellingPage
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
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option4 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cheer = new System.Windows.Forms.Label();
            this.smiley = new System.Windows.Forms.PictureBox();
            this.playAgain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.smiley)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain)).BeginInit();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.option1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option1.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(67, 46);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(413, 105);
            this.option1.TabIndex = 1;
            this.option1.Text = "Option 1";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.option2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option2.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(517, 46);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(413, 106);
            this.option2.TabIndex = 2;
            this.option2.Text = "Option 2";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option4
            // 
            this.option4.BackColor = System.Drawing.Color.Magenta;
            this.option4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option4.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4.Location = new System.Drawing.Point(517, 174);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(413, 94);
            this.option4.TabIndex = 3;
            this.option4.Text = "Option 4";
            this.option4.UseVisualStyleBackColor = false;
            this.option4.Click += new System.EventHandler(this.option4_Click);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.option3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option3.Font = new System.Drawing.Font("Lemon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(67, 174);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(413, 94);
            this.option3.TabIndex = 4;
            this.option3.Text = "Option 3";
            this.option3.UseVisualStyleBackColor = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click To Listen Again";
            // 
            // cheer
            // 
            this.cheer.AutoSize = true;
            this.cheer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cheer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheer.ForeColor = System.Drawing.Color.DarkRed;
            this.cheer.Location = new System.Drawing.Point(413, 366);
            this.cheer.Name = "cheer";
            this.cheer.Size = new System.Drawing.Size(102, 42);
            this.cheer.TabIndex = 7;
            this.cheer.Text = "label";
            this.cheer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smiley
            // 
            this.smiley.BackColor = System.Drawing.Color.Transparent;
            this.smiley.Image = global::SpellingGame.Properties.Resources.smile;
            this.smiley.Location = new System.Drawing.Point(259, 334);
            this.smiley.Name = "smiley";
            this.smiley.Size = new System.Drawing.Size(134, 104);
            this.smiley.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smiley.TabIndex = 8;
            this.smiley.TabStop = false;
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.Transparent;
            this.playAgain.Image = global::SpellingGame.Properties.Resources.play_button;
            this.playAgain.Location = new System.Drawing.Point(42, 333);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(151, 105);
            this.playAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playAgain.TabIndex = 5;
            this.playAgain.TabStop = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // SpellingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpellingGame.Properties.Resources.books_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.smiley);
            this.Controls.Add(this.cheer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Name = "SpellingPage";
            this.Text = "Spelling Page";
            ((System.ComponentModel.ISupportInitialize)(this.smiley)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option4;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.PictureBox playAgain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cheer;
        private System.Windows.Forms.PictureBox smiley;
    }
}