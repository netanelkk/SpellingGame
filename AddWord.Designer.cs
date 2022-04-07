namespace SpellingGame
{
    partial class AddWord
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
            this.spellbox = new System.Windows.Forms.GroupBox();
            this.save_spell = new System.Windows.Forms.Button();
            this.txt_wrong3 = new System.Windows.Forms.TextBox();
            this.txt_wrong2 = new System.Windows.Forms.TextBox();
            this.txt_wrong1 = new System.Windows.Forms.TextBox();
            this.spell_audio = new System.Windows.Forms.Button();
            this.spell_word = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gamebox = new System.Windows.Forms.GroupBox();
            this.picture_preview = new System.Windows.Forms.PictureBox();
            this.game_image = new System.Windows.Forms.Button();
            this.save_game = new System.Windows.Forms.Button();
            this.game_audio = new System.Windows.Forms.Button();
            this.game_word = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.show_spelling = new System.Windows.Forms.Button();
            this.show_games = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.spellbox.SuspendLayout();
            this.gamebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // spellbox
            // 
            this.spellbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.spellbox.Controls.Add(this.save_spell);
            this.spellbox.Controls.Add(this.txt_wrong3);
            this.spellbox.Controls.Add(this.txt_wrong2);
            this.spellbox.Controls.Add(this.txt_wrong1);
            this.spellbox.Controls.Add(this.spell_audio);
            this.spellbox.Controls.Add(this.spell_word);
            this.spellbox.Controls.Add(this.label3);
            this.spellbox.Controls.Add(this.label2);
            this.spellbox.Controls.Add(this.label1);
            this.spellbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellbox.Location = new System.Drawing.Point(12, 108);
            this.spellbox.Name = "spellbox";
            this.spellbox.Size = new System.Drawing.Size(712, 225);
            this.spellbox.TabIndex = 0;
            this.spellbox.TabStop = false;
            this.spellbox.Text = "Add Word To Spelling";
            this.spellbox.Visible = false;
            // 
            // save_spell
            // 
            this.save_spell.Location = new System.Drawing.Point(530, 56);
            this.save_spell.Name = "save_spell";
            this.save_spell.Size = new System.Drawing.Size(134, 103);
            this.save_spell.TabIndex = 7;
            this.save_spell.Text = "Save";
            this.save_spell.UseVisualStyleBackColor = true;
            this.save_spell.Click += new System.EventHandler(this.save_spell_Click);
            // 
            // txt_wrong3
            // 
            this.txt_wrong3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wrong3.Location = new System.Drawing.Point(170, 177);
            this.txt_wrong3.Name = "txt_wrong3";
            this.txt_wrong3.Size = new System.Drawing.Size(198, 26);
            this.txt_wrong3.TabIndex = 6;
            // 
            // txt_wrong2
            // 
            this.txt_wrong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wrong2.Location = new System.Drawing.Point(170, 147);
            this.txt_wrong2.Name = "txt_wrong2";
            this.txt_wrong2.Size = new System.Drawing.Size(198, 26);
            this.txt_wrong2.TabIndex = 5;
            // 
            // txt_wrong1
            // 
            this.txt_wrong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wrong1.Location = new System.Drawing.Point(170, 117);
            this.txt_wrong1.Name = "txt_wrong1";
            this.txt_wrong1.Size = new System.Drawing.Size(198, 26);
            this.txt_wrong1.TabIndex = 4;
            // 
            // spell_audio
            // 
            this.spell_audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spell_audio.Location = new System.Drawing.Point(127, 83);
            this.spell_audio.Name = "spell_audio";
            this.spell_audio.Size = new System.Drawing.Size(164, 27);
            this.spell_audio.TabIndex = 3;
            this.spell_audio.Text = "Choose File...";
            this.spell_audio.UseVisualStyleBackColor = true;
            this.spell_audio.Click += new System.EventHandler(this.spellaudio_Click);
            // 
            // spell_word
            // 
            this.spell_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spell_word.Location = new System.Drawing.Point(95, 53);
            this.spell_word.Name = "spell_word";
            this.spell_word.Size = new System.Drawing.Size(198, 26);
            this.spell_word.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wrong Spellings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Audio File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word:";
            // 
            // gamebox
            // 
            this.gamebox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gamebox.Controls.Add(this.picture_preview);
            this.gamebox.Controls.Add(this.game_image);
            this.gamebox.Controls.Add(this.save_game);
            this.gamebox.Controls.Add(this.game_audio);
            this.gamebox.Controls.Add(this.game_word);
            this.gamebox.Controls.Add(this.label4);
            this.gamebox.Controls.Add(this.label5);
            this.gamebox.Controls.Add(this.label6);
            this.gamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamebox.Location = new System.Drawing.Point(12, 339);
            this.gamebox.Name = "gamebox";
            this.gamebox.Size = new System.Drawing.Size(712, 225);
            this.gamebox.TabIndex = 1;
            this.gamebox.TabStop = false;
            this.gamebox.Text = "Add Word To Games";
            this.gamebox.Visible = false;
            // 
            // picture_preview
            // 
            this.picture_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_preview.Location = new System.Drawing.Point(12, 56);
            this.picture_preview.Name = "picture_preview";
            this.picture_preview.Size = new System.Drawing.Size(154, 103);
            this.picture_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_preview.TabIndex = 9;
            this.picture_preview.TabStop = false;
            // 
            // game_image
            // 
            this.game_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_image.Location = new System.Drawing.Point(289, 132);
            this.game_image.Name = "game_image";
            this.game_image.Size = new System.Drawing.Size(164, 27);
            this.game_image.TabIndex = 8;
            this.game_image.Text = "Choose File...";
            this.game_image.UseVisualStyleBackColor = true;
            this.game_image.Click += new System.EventHandler(this.game_image_Click);
            // 
            // save_game
            // 
            this.save_game.Location = new System.Drawing.Point(530, 56);
            this.save_game.Name = "save_game";
            this.save_game.Size = new System.Drawing.Size(134, 103);
            this.save_game.TabIndex = 7;
            this.save_game.Text = "Save";
            this.save_game.UseVisualStyleBackColor = true;
            this.save_game.Click += new System.EventHandler(this.save_game_Click);
            // 
            // game_audio
            // 
            this.game_audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_audio.Location = new System.Drawing.Point(285, 97);
            this.game_audio.Name = "game_audio";
            this.game_audio.Size = new System.Drawing.Size(164, 27);
            this.game_audio.TabIndex = 3;
            this.game_audio.Text = "Choose File...";
            this.game_audio.UseVisualStyleBackColor = true;
            this.game_audio.Click += new System.EventHandler(this.game_audio_Click);
            // 
            // game_word
            // 
            this.game_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_word.Location = new System.Drawing.Point(253, 67);
            this.game_word.Name = "game_word";
            this.game_word.Size = new System.Drawing.Size(198, 26);
            this.game_word.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Image File:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Audio File:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Word:";
            // 
            // show_spelling
            // 
            this.show_spelling.Location = new System.Drawing.Point(24, 26);
            this.show_spelling.Name = "show_spelling";
            this.show_spelling.Size = new System.Drawing.Size(153, 57);
            this.show_spelling.TabIndex = 8;
            this.show_spelling.Text = "Add To Spelling";
            this.show_spelling.UseVisualStyleBackColor = true;
            this.show_spelling.Click += new System.EventHandler(this.show_spelling_Click);
            // 
            // show_games
            // 
            this.show_games.Location = new System.Drawing.Point(194, 26);
            this.show_games.Name = "show_games";
            this.show_games.Size = new System.Drawing.Size(153, 57);
            this.show_games.TabIndex = 9;
            this.show_games.Text = "Add To Games";
            this.show_games.UseVisualStyleBackColor = true;
            this.show_games.Click += new System.EventHandler(this.show_games_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.LightCoral;
            this.exitbutton.Location = new System.Drawing.Point(631, 26);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(93, 57);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 598);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.show_games);
            this.Controls.Add(this.show_spelling);
            this.Controls.Add(this.gamebox);
            this.Controls.Add(this.spellbox);
            this.Name = "AddWord";
            this.Text = "AddWord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddWord_FormClosed);
            this.spellbox.ResumeLayout(false);
            this.spellbox.PerformLayout();
            this.gamebox.ResumeLayout(false);
            this.gamebox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox spellbox;
        private System.Windows.Forms.Button save_spell;
        private System.Windows.Forms.TextBox txt_wrong3;
        private System.Windows.Forms.TextBox txt_wrong2;
        private System.Windows.Forms.TextBox txt_wrong1;
        private System.Windows.Forms.Button spell_audio;
        private System.Windows.Forms.TextBox spell_word;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gamebox;
        private System.Windows.Forms.PictureBox picture_preview;
        private System.Windows.Forms.Button game_image;
        private System.Windows.Forms.Button save_game;
        private System.Windows.Forms.Button game_audio;
        private System.Windows.Forms.TextBox game_word;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button show_spelling;
        private System.Windows.Forms.Button show_games;
        private System.Windows.Forms.Button exitbutton;
    }
}