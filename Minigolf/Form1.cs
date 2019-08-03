using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGolf
{
    public partial class Form1 : Form
    {
        public int numPlayers = 0;
        ScoreCard playerone = new ScoreCard("temp");
        ScoreCard playertwo = new ScoreCard("temp");
        ScoreCard playerthree = new ScoreCard("temp");
        ScoreCard playerfour = new ScoreCard("temp");

        private void btn_AddScore_Click(object sender, EventArgs e)
        {
            if (numPlayers < 2)
            {
                MessageBox.Show("There aren't enough players.");
            }
            else
            {
                int hole = int.Parse(txt_Hole.Text);
                int score = int.Parse(txt_Strokes.Text);
                int player = lBox_Players.SelectedIndex;
                bool success = false;

                switch (player)
                {
                    case 0:
                        playerone.enterScore(hole, score);
                        success = true;
                        break;
                    case 1:
                        playertwo.enterScore(hole, score);
                        success = true;
                        break;
                    case 2:
                        playerthree.enterScore(hole, score);
                        success = true;
                        break;
                    case 3:
                        playerfour.enterScore(hole, score);
                        success = true;
                        break;
                    case -1:
                        MessageBox.Show("Make sure you select a player.");
                        break;
                    default:
                        MessageBox.Show("Something broke.");
                        break;
                }
                if (success == true)
                {
                    MessageBox.Show("Score added.");
                    string allScores = "";
                    switch (numPlayers)
                    {
                        case 2:
                            allScores += playerone.name + "\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playerone.getScore(x)}";
                            }
                            allScores += $"\n\n{playertwo.name}\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playertwo.getScore(x)}";
                            }
                            break;
                        case 3:
                            allScores += playerone.name + "\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playerone.getScore(x)}";
                            }
                            allScores += $"\n\n{playertwo.name}\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playertwo.getScore(x)}";
                            }
                            allScores += $"\n\n{playerthree.name}\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playerthree.getScore(x)}";
                            }
                            break;
                        case 4:
                            allScores += playerone.name + "\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playerone.getScore(x)}";
                            }
                            allScores += $"\n\n{playertwo.name}\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playertwo.getScore(x)}";
                            }
                            allScores += $"\n\n{playerthree.name}\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playerthree.getScore(x)}";
                            }
                            allScores += $"\n\n{playerfour.name}\n";
                            for (int x = 1; x <= 18; x++)
                            {
                                allScores += $" {playerfour.getScore(x)}";
                            }
                            break;
                    }
                    MessageBox.Show(allScores);
                }
            }
        }

        private void btn_newPlayer_Click(object sender, EventArgs e)
        {
            switch (numPlayers)
            {
                case 0:
                    playerone.name = txt_Player.Text;
                    lBox_Players.Items.Add(playerone.name);
                    numPlayers++;
                    break;
                case 1:
                    playertwo.name = txt_Player.Text;
                    lBox_Players.Items.Add(playertwo.name);
                    numPlayers++;
                    break;
                case 2:
                    playerthree.name = txt_Player.Text;
                    lBox_Players.Items.Add(playerthree.name);
                    numPlayers++;
                    break;
                case 3:
                    playerfour.name = txt_Player.Text;
                    lBox_Players.Items.Add(playerfour.name);
                    numPlayers++;
                    break;
                default:
                    MessageBox.Show("Cannot add anymore players.");
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Winner_Click(object sender, EventArgs e)
        {
            switch (numPlayers)
            {
                case 2:
                    if (playerone.totalScore() < playertwo.totalScore())
                    {
                        MessageBox.Show($"{playerone.name} is winning!");
                    }
                    else
                    {
                        MessageBox.Show($"{playertwo.name} is winning!");
                    }
                    break;
                case 3:
                    if (playerone.totalScore() < playertwo.totalScore() && playerone.totalScore() < playerthree.totalScore())
                    {
                        MessageBox.Show($"{playerone.name} is winning!");
                    }
                    else if (playertwo.totalScore() < playerone.totalScore() && playertwo.totalScore() < playerthree.totalScore())
                    {
                        MessageBox.Show($"{playertwo.name} is winning!");
                    }
                    else
                    {
                        MessageBox.Show($"{playerthree.name} is winning!");
                    }
                    break;
                case 4:
                    if (playerone.totalScore() < playertwo.totalScore() && playerone.totalScore() < playerthree.totalScore() && playerone.totalScore() < playerfour.totalScore())
                    {
                        MessageBox.Show($"{playerone.name} is winning!");
                    }
                    else if (playertwo.totalScore() < playerone.totalScore() && playertwo.totalScore() < playerthree.totalScore() && playertwo.totalScore() < playerfour.totalScore())
                    {
                        MessageBox.Show($"{playertwo.name} is winning!");
                    }
                    else if (playerthree.totalScore() < playerone.totalScore() && playerthree.totalScore() < playertwo.totalScore() && playerthree.totalScore() < playerfour.totalScore())
                    {
                        MessageBox.Show($"{playerthree.name} is winning!");
                    }
                    else
                    {
                        MessageBox.Show($"{playerfour.name} is winning!");
                    }
                    break;
                default:
                    if (numPlayers < 2)
                    {
                        MessageBox.Show("There aren't enough players.");
                    }
                    else
                    {
                        MessageBox.Show("Something broke.");
                    }
                    break;
            }
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            if (numPlayers < 2)
            {
                MessageBox.Show("You need more players!");
            }
            else
            {
                switch (numPlayers)
                {
                    case 2:
                        playerone.resetGame();
                        playertwo.resetGame();
                        break;
                    case 3:
                        playerone.resetGame();
                        playertwo.resetGame();
                        playerthree.resetGame();
                        break;
                    case 4:
                        playerone.resetGame();
                        playertwo.resetGame();
                        playerthree.resetGame();
                        playerfour.resetGame();
                        break;
                }
            }
        }
    }
}
