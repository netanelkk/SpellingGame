namespace SpellingGame
{
    partial class CompleteTheWordGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.thepicture = new System.Windows.Forms.PictureBox();
            this.theword = new System.Windows.Forms.Label();
            this.letter1 = new System.Windows.Forms.Button();
            this.letter2 = new System.Windows.Forms.Button();
            this.letter3 = new System.Windows.Forms.Button();
            this.letter4 = new System.Windows.Forms.Button();
            this.WaitBetweenQuestions = new System.Windows.Forms.Timer(this.components);
            this.smiley = new System.Windows.Forms.PictureBox();
            this.DisplayWrongWord = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.thepicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiley)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Kalam", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete The Word";
            // 
            // thepicture
            // 
            this.thepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.thepicture.Location = new System.Drawing.Point(374, 100);
            this.thepicture.Name = "thepicture";
            this.thepicture.Size = new System.Drawing.Size(232, 184);
            this.thepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thepicture.TabIndex = 1;
            this.thepicture.TabStop = false;
            // 
            // theword
            // 
            this.theword.AutoSize = true;
            this.theword.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.theword.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theword.Location = new System.Drawing.Point(416, 297);
            this.theword.Name = "theword";
            this.theword.Size = new System.Drawing.Size(152, 55);
            this.theword.TabIndex = 2;
            this.theword.Text = "label2";
            // 
            // letter1
            // 
            this.letter1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.letter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter1.Location = new System.Drawing.Point(599, 373);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(75, 65);
            this.letter1.TabIndex = 3;
            this.letter1.Text = "A";
            this.letter1.UseVisualStyleBackColor = false;
            this.letter1.Click += new System.EventHandler(this.letter1_Click);
            // 
            // letter2
            // 
            this.letter2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.letter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter2.Location = new System.Drawing.Point(502, 373);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(75, 65);
            this.letter2.TabIndex = 4;
            this.letter2.Text = "A";
            this.letter2.UseVisualStyleBackColor = false;
            this.letter2.Click += new System.EventHandler(this.letter2_Click);
            // 
            // letter3
            // 
            this.letter3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.letter3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter3.Location = new System.Drawing.Point(402, 373);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(75, 65);
            this.letter3.TabIndex = 5;
            this.letter3.Text = "A";
            this.letter3.UseVisualStyleBackColor = false;
            this.letter3.Click += new System.EventHandler(this.letter3_Click);
            // 
            // letter4
            // 
            this.letter4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.letter4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter4.Location = new System.Drawing.Point(303, 373);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(75, 65);
            this.letter4.TabIndex = 6;
            this.letter4.Text = "A";
            this.letter4.UseVisualStyleBackColor = false;
            this.letter4.Click += new System.EventHandler(this.letter4_Click);
            // 
            // WaitBetweenQuestions
            // 
            this.WaitBetweenQuestions.Interval = 1000;
            this.WaitBetweenQuestions.Tick += new System.EventHandler(this.WaitBetweenQuestions_Tick);
            // 
            // smiley
            // 
            this.smiley.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.smiley.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.smiley.Image = global::SpellingGame.Properties.Resources.smile;
            this.smiley.Location = new System.Drawing.Point(217, 148);
            this.smiley.Name = "smiley";
            this.smiley.Size = new System.Drawing.Size(139, 106);
            this.smiley.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smiley.TabIndex = 7;
            this.smiley.TabStop = false;
            // 
            // DisplayWrongWord
            // 
            this.DisplayWrongWord.Interval = 1000;
            this.DisplayWrongWord.Tick += new System.EventHandler(this.DisplayWrongWord_Tick);
            // 
            // CompleteTheWordGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpellingGame.Properties.Resources.clouds_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.smiley);
            this.Controls.Add(this.letter4);
            this.Controls.Add(this.letter3);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.theword);
            this.Controls.Add(this.thepicture);
            this.Controls.Add(this.label1);
            this.Name = "CompleteTheWordGame";
            this.Text = "Complete The Word Game";
            ((System.ComponentModel.ISupportInitialize)(this.thepicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smiley)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox thepicture;
        private System.Windows.Forms.Label theword;
        private System.Windows.Forms.Button letter1;
        private System.Windows.Forms.Button letter2;
        private System.Windows.Forms.Button letter3;
        private System.Windows.Forms.Button letter4;
        private System.Windows.Forms.Timer WaitBetweenQuestions;
        private System.Windows.Forms.PictureBox smiley;
        private System.Windows.Forms.Timer DisplayWrongWord;
    }
}