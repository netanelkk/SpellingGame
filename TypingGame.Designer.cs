namespace SpellingGame
{
    partial class TypingGame
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lblCharcter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start_game = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txt_word = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check_btn = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("Hadassah Friedlaender", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(362, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typing Game";
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.gamePanel.Controls.Add(this.lblCharcter);
            this.gamePanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gamePanel.Location = new System.Drawing.Point(1, 52);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(715, 308);
            this.gamePanel.TabIndex = 1;
            // 
            // lblCharcter
            // 
            this.lblCharcter.AutoSize = true;
            this.lblCharcter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCharcter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharcter.Location = new System.Drawing.Point(250, 29);
            this.lblCharcter.Name = "lblCharcter";
            this.lblCharcter.Size = new System.Drawing.Size(51, 55);
            this.lblCharcter.TabIndex = 4;
            this.lblCharcter.Text = "a";
            this.lblCharcter.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 70);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type on keyboard the letters that falls, and try to recognize the word. After tha" +
    "t, you would have to write it on the right";
            // 
            // start_game
            // 
            this.start_game.BackColor = System.Drawing.Color.PaleGreen;
            this.start_game.Font = new System.Drawing.Font("Lemon", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_game.ForeColor = System.Drawing.Color.ForestGreen;
            this.start_game.Location = new System.Drawing.Point(738, 366);
            this.start_game.Name = "start_game";
            this.start_game.Size = new System.Drawing.Size(234, 90);
            this.start_game.TabIndex = 3;
            this.start_game.Text = "Start Game";
            this.start_game.UseVisualStyleBackColor = false;
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 55);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(576, 382);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 55);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // txt_word
            // 
            this.txt_word.BackColor = System.Drawing.SystemColors.Info;
            this.txt_word.Enabled = false;
            this.txt_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_word.Location = new System.Drawing.Point(738, 155);
            this.txt_word.Name = "txt_word";
            this.txt_word.Size = new System.Drawing.Size(220, 47);
            this.txt_word.TabIndex = 6;
            this.txt_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter The Word:";
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check_btn.Enabled = false;
            this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.check_btn.Location = new System.Drawing.Point(755, 208);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(184, 79);
            this.check_btn.TabIndex = 8;
            this.check_btn.Text = "CHECK";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // TypingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpellingGame.Properties.Resources.clouds_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txt_word);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start_game);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "TypingGame";
            this.Text = "Typing Game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCharcter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_game;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.TextBox txt_word;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button check_btn;
    }
}