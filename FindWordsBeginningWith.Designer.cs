namespace SpellingGame
{
    partial class FindWordsBeginningWith
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
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_clock = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.choosen_letter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.option1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(168, 178);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(207, 67);
            this.option1.TabIndex = 0;
            this.option1.Text = "button1";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.option2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(304, 38);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(178, 55);
            this.option2.TabIndex = 1;
            this.option2.Text = "button2";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.Lime;
            this.option3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(453, 246);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(208, 67);
            this.option3.TabIndex = 2;
            this.option3.Text = "button3";
            this.option3.UseVisualStyleBackColor = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // picture1
            // 
            this.picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture1.Location = new System.Drawing.Point(546, 29);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(178, 132);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 3;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture2
            // 
            this.picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture2.Location = new System.Drawing.Point(766, 209);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(185, 138);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 4;
            this.picture2.TabStop = false;
            this.picture2.Click += new System.EventHandler(this.picture2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(208, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Left:";
            // 
            // timer_clock
            // 
            this.timer_clock.AutoSize = true;
            this.timer_clock.BackColor = System.Drawing.Color.DarkBlue;
            this.timer_clock.Font = new System.Drawing.Font("Doppio One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_clock.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timer_clock.Location = new System.Drawing.Point(388, 382);
            this.timer_clock.Name = "timer_clock";
            this.timer_clock.Size = new System.Drawing.Size(42, 46);
            this.timer_clock.TabIndex = 6;
            this.timer_clock.Text = "5";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // choosen_letter
            // 
            this.choosen_letter.AutoSize = true;
            this.choosen_letter.BackColor = System.Drawing.Color.DarkBlue;
            this.choosen_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosen_letter.ForeColor = System.Drawing.Color.Silver;
            this.choosen_letter.Location = new System.Drawing.Point(29, 283);
            this.choosen_letter.Name = "choosen_letter";
            this.choosen_letter.Size = new System.Drawing.Size(155, 152);
            this.choosen_letter.TabIndex = 7;
            this.choosen_letter.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(456, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score:";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.DarkBlue;
            this.scorelabel.Font = new System.Drawing.Font("Doppio One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.scorelabel.Location = new System.Drawing.Point(581, 383);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(68, 46);
            this.scorelabel.TabIndex = 9;
            this.scorelabel.Text = "50";
            // 
            // FindWordsBeginningWith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpellingGame.Properties.Resources.clouds_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choosen_letter);
            this.Controls.Add(this.timer_clock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Name = "FindWordsBeginningWith";
            this.Text = "Find Words Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindWordsBeginningWith_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timer_clock;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label choosen_letter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scorelabel;
    }
}