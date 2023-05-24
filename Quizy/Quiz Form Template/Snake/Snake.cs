using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Quizy.Quiz_Form_Template.Snake
{
    public partial class SnakeGame : Form
    {
        //Variables
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;
        
        int maxWidth;
        int maxHeight;

        int score;
        public int time;
        public int requiredScore = 100;
        public int increment = 10;        
        public bool isFinished = false;

        //Fuctions
        public SnakeGame()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
            new Settings();
            startGame();
            RequiredScore.Text = requiredScore.ToString();
            labelScore.Text = "Score:";
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }
        private void EatFood()
        {
            score += increment;
            Score.Text = score.ToString();
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };                      
            if(score == requiredScore)
            {
                timerTick.Stop();
                timerTime.Stop();
                timerMovement.Stop();
                MessageBox.Show("Ai câștigat!", "Ai câștigat!");
            }
        }

        private void pictureBoxGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            time--;
            labelTime.Text = time.ToString();
            if(time<=0) 
            {
                GameOver();
            }
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            pictureBoxGame.Invalidate();
        }

        

        private void startGame()
        {
            maxWidth = pictureBoxGame.Width / Settings.Width - 1;
            maxHeight = pictureBoxGame.Height / Settings.Height - 1;
            Snake.Clear();
            score = 0;
            Score.Text = "Score: " + score;
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list
            Circle body = new Circle();
            Snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            timerTick.Start();
            timerTime.Start();
            timerMovement.Start();
        }

         
        async private void GameOver()
        {
            timerTick.Stop();
            timerTime.Stop();
            timerMovement.Stop();
            MessageBox.Show("Ai pierdut!\nJocul v-a reîncepe în cinci secunde!", "Ai piretdut!");
            await Task.Delay(500);
            startGame();
        }
    }
}
