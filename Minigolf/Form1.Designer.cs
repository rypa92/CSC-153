namespace MiniGolf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lBox_Players = new System.Windows.Forms.ListBox();
            this.btn_newPlayer = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.gBox_addPlayer = new System.Windows.Forms.GroupBox();
            this.txt_Player = new System.Windows.Forms.TextBox();
            this.lbl_Setup = new System.Windows.Forms.Label();
            this.gBox_enterScore = new System.Windows.Forms.GroupBox();
            this.txt_Strokes = new System.Windows.Forms.TextBox();
            this.lbl_Strokes = new System.Windows.Forms.Label();
            this.txt_Hole = new System.Windows.Forms.TextBox();
            this.lbl_Hole = new System.Windows.Forms.Label();
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.gBox_Players = new System.Windows.Forms.GroupBox();
            this.btn_Winner = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.tt_NewGame = new System.Windows.Forms.ToolTip(this.components);
            this.tt_Winner = new System.Windows.Forms.ToolTip(this.components);
            this.tt_AddPlayer = new System.Windows.Forms.ToolTip(this.components);
            this.tt_AddScore = new System.Windows.Forms.ToolTip(this.components);
            this.gBox_addPlayer.SuspendLayout();
            this.gBox_enterScore.SuspendLayout();
            this.gBox_Players.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(158, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(211, 55);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Mini Golf";
            // 
            // lBox_Players
            // 
            this.lBox_Players.FormattingEnabled = true;
            this.lBox_Players.Location = new System.Drawing.Point(6, 19);
            this.lBox_Players.Name = "lBox_Players";
            this.lBox_Players.Size = new System.Drawing.Size(236, 56);
            this.lBox_Players.TabIndex = 2;
            // 
            // btn_newPlayer
            // 
            this.btn_newPlayer.Location = new System.Drawing.Point(167, 34);
            this.btn_newPlayer.Name = "btn_newPlayer";
            this.btn_newPlayer.Size = new System.Drawing.Size(75, 23);
            this.btn_newPlayer.TabIndex = 3;
            this.btn_newPlayer.Text = "Add Player";
            this.tt_AddPlayer.SetToolTip(this.btn_newPlayer, "This button adds new players to the game. You must have atleast two to begin addi" +
        "ng scores,\r\nbut currently this program only allows up to four total players.");
            this.btn_newPlayer.UseVisualStyleBackColor = true;
            this.btn_newPlayer.Click += new System.EventHandler(this.btn_newPlayer_Click);
            // 
            // btn_newGame
            // 
            this.btn_newGame.Location = new System.Drawing.Point(6, 81);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(236, 23);
            this.btn_newGame.TabIndex = 4;
            this.btn_newGame.Text = "New Game";
            this.tt_NewGame.SetToolTip(this.btn_newGame, "This button takes each player and clears their current scores.\r\nThis will allow y" +
        "ou to play multiple games with the same people.");
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // gBox_addPlayer
            // 
            this.gBox_addPlayer.Controls.Add(this.txt_Player);
            this.gBox_addPlayer.Controls.Add(this.lbl_Setup);
            this.gBox_addPlayer.Controls.Add(this.btn_newPlayer);
            this.gBox_addPlayer.Location = new System.Drawing.Point(266, 67);
            this.gBox_addPlayer.Name = "gBox_addPlayer";
            this.gBox_addPlayer.Size = new System.Drawing.Size(248, 64);
            this.gBox_addPlayer.TabIndex = 5;
            this.gBox_addPlayer.TabStop = false;
            this.gBox_addPlayer.Text = "Add A Player";
            // 
            // txt_Player
            // 
            this.txt_Player.Location = new System.Drawing.Point(6, 36);
            this.txt_Player.Name = "txt_Player";
            this.txt_Player.Size = new System.Drawing.Size(154, 20);
            this.txt_Player.TabIndex = 5;
            // 
            // lbl_Setup
            // 
            this.lbl_Setup.AutoSize = true;
            this.lbl_Setup.Location = new System.Drawing.Point(7, 20);
            this.lbl_Setup.Name = "lbl_Setup";
            this.lbl_Setup.Size = new System.Drawing.Size(73, 13);
            this.lbl_Setup.TabIndex = 4;
            this.lbl_Setup.Text = "Player Name: ";
            // 
            // gBox_enterScore
            // 
            this.gBox_enterScore.Controls.Add(this.txt_Strokes);
            this.gBox_enterScore.Controls.Add(this.lbl_Strokes);
            this.gBox_enterScore.Controls.Add(this.txt_Hole);
            this.gBox_enterScore.Controls.Add(this.lbl_Hole);
            this.gBox_enterScore.Controls.Add(this.btn_AddScore);
            this.gBox_enterScore.Location = new System.Drawing.Point(266, 137);
            this.gBox_enterScore.Name = "gBox_enterScore";
            this.gBox_enterScore.Size = new System.Drawing.Size(248, 64);
            this.gBox_enterScore.TabIndex = 6;
            this.gBox_enterScore.TabStop = false;
            this.gBox_enterScore.Text = "Enter Scores";
            // 
            // txt_Strokes
            // 
            this.txt_Strokes.Location = new System.Drawing.Point(86, 36);
            this.txt_Strokes.Name = "txt_Strokes";
            this.txt_Strokes.Size = new System.Drawing.Size(74, 20);
            this.txt_Strokes.TabIndex = 7;
            // 
            // lbl_Strokes
            // 
            this.lbl_Strokes.AutoSize = true;
            this.lbl_Strokes.Location = new System.Drawing.Point(87, 20);
            this.lbl_Strokes.Name = "lbl_Strokes";
            this.lbl_Strokes.Size = new System.Drawing.Size(46, 13);
            this.lbl_Strokes.TabIndex = 6;
            this.lbl_Strokes.Text = "Strokes:";
            // 
            // txt_Hole
            // 
            this.txt_Hole.Location = new System.Drawing.Point(6, 36);
            this.txt_Hole.Name = "txt_Hole";
            this.txt_Hole.Size = new System.Drawing.Size(74, 20);
            this.txt_Hole.TabIndex = 5;
            // 
            // lbl_Hole
            // 
            this.lbl_Hole.AutoSize = true;
            this.lbl_Hole.Location = new System.Drawing.Point(7, 20);
            this.lbl_Hole.Name = "lbl_Hole";
            this.lbl_Hole.Size = new System.Drawing.Size(32, 13);
            this.lbl_Hole.TabIndex = 4;
            this.lbl_Hole.Text = "Hole:";
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.Location = new System.Drawing.Point(167, 34);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(75, 23);
            this.btn_AddScore.TabIndex = 3;
            this.btn_AddScore.Text = "Add Score";
            this.tt_AddScore.SetToolTip(this.btn_AddScore, resources.GetString("btn_AddScore.ToolTip"));
            this.btn_AddScore.UseVisualStyleBackColor = true;
            this.btn_AddScore.Click += new System.EventHandler(this.btn_AddScore_Click);
            // 
            // gBox_Players
            // 
            this.gBox_Players.Controls.Add(this.lBox_Players);
            this.gBox_Players.Controls.Add(this.btn_Winner);
            this.gBox_Players.Controls.Add(this.btn_newGame);
            this.gBox_Players.Location = new System.Drawing.Point(12, 67);
            this.gBox_Players.Name = "gBox_Players";
            this.gBox_Players.Size = new System.Drawing.Size(248, 134);
            this.gBox_Players.TabIndex = 7;
            this.gBox_Players.TabStop = false;
            this.gBox_Players.Text = "Players";
            // 
            // btn_Winner
            // 
            this.btn_Winner.Location = new System.Drawing.Point(6, 107);
            this.btn_Winner.Name = "btn_Winner";
            this.btn_Winner.Size = new System.Drawing.Size(236, 21);
            this.btn_Winner.TabIndex = 8;
            this.btn_Winner.Text = "Winner Winner";
            this.tt_Winner.SetToolTip(this.btn_Winner, "This button tallies all the scores together and shows you the current winner.");
            this.btn_Winner.UseVisualStyleBackColor = true;
            this.btn_Winner.Click += new System.EventHandler(this.btn_Winner_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(59, 207);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(408, 13);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "Add players to the game and select the player in the box to add scores for that p" +
    "layer.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 229);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.gBox_Players);
            this.Controls.Add(this.gBox_enterScore);
            this.Controls.Add(this.gBox_addPlayer);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBox_addPlayer.ResumeLayout(false);
            this.gBox_addPlayer.PerformLayout();
            this.gBox_enterScore.ResumeLayout(false);
            this.gBox_enterScore.PerformLayout();
            this.gBox_Players.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListBox lBox_Players;
        private System.Windows.Forms.Button btn_newPlayer;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.GroupBox gBox_addPlayer;
        private System.Windows.Forms.TextBox txt_Player;
        private System.Windows.Forms.Label lbl_Setup;
        private System.Windows.Forms.GroupBox gBox_enterScore;
        private System.Windows.Forms.TextBox txt_Strokes;
        private System.Windows.Forms.Label lbl_Strokes;
        private System.Windows.Forms.TextBox txt_Hole;
        private System.Windows.Forms.Label lbl_Hole;
        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.GroupBox gBox_Players;
        private System.Windows.Forms.Button btn_Winner;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ToolTip tt_AddPlayer;
        private System.Windows.Forms.ToolTip tt_NewGame;
        private System.Windows.Forms.ToolTip tt_AddScore;
        private System.Windows.Forms.ToolTip tt_Winner;
    }
}

