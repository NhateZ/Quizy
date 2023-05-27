using Quizy.program_interpretor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy.Quiz_Form_Template
{
    public partial class PopQuizGameQuiz : Form
    {
        //Variables
        public short rightAnswer { get; set; }
        /*
         * 0 - Red
         * 1 - Green
         * 2 - Blue
         * 3 - Yellow
        */
        public int time = 100;
        public bool isFinished = false;
        public string question;
        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;

        private int mistakes = 2;

        public PopQuizGameQuiz()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
            labelTimer.Text = time.ToString();

        }
        private void gameStart()
        {
            answerRed.Text = answer1;
            answerGreen.Text = answer2;
            answerBlue.Text = answer3;
            answerYellow.Text = answer4;
            timer.Start();
        }

        private void answerRed_Click(object sender, EventArgs e)
        {
            if (rightAnswer == 0)
            {
                MessageBox.Show("Ai câștigat!", "Ai câștigat!");
                interpretor intr = new interpretor();
                if (mistakes >= 2)
                    intr.addPoints(100);
                else
                    intr.addPoints(50);
                this.Close();
            }
            else
            {
                mistakes--;
                if (mistakes <= 0)
                {
                    MessageBox.Show("Ai pierdut!", "Ai pierdut!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mai ai o incercare!");
                }
            }
        }

        private void answerGreen_Click(object sender, EventArgs e)
        {
            if (rightAnswer == 1)
            {
                interpretor intr = new interpretor();
                MessageBox.Show("Ai câștigat!", "Ai câștigat!");
                if (mistakes >= 2)
                    intr.addPoints(100);
                else
                    intr.addPoints(50);
                this.Close();
            }
            else
            {
                mistakes--;
                if (mistakes <= 0)
                {
                    MessageBox.Show("Ai pierdut!", "Ai pierdut!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mai ai o incercare!");
                }
            }
        }

        private void answerBlue_Click(object sender, EventArgs e)
        {
            if (rightAnswer == 2)
            {
                interpretor intr = new interpretor();
                MessageBox.Show("Ai câștigat!", "Ai câștigat!");
                if (mistakes >= 2)
                    intr.addPoints(100);
                else
                    intr.addPoints(50);
                this.Close();
            }
            else
            {
                mistakes--;
                if (mistakes <= 0)
                {
                    MessageBox.Show("Ai pierdut!", "Ai pierdut!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mai ai o incercare!");
                }
            }
        }

        private void answerYellow_Click(object sender, EventArgs e)
        {
            if (rightAnswer == 3)
            {
                interpretor intr = new interpretor();
                MessageBox.Show("Ai câștigat!", "Ai câștigat!");
                if (mistakes >= 2)
                    intr.addPoints(100);
                else
                    intr.addPoints(50);
                this.Close();
            }
            else
            {
                mistakes--;
                if (mistakes <= 0)
                {
                    MessageBox.Show("Ai pierdut!", "Ai pierdut!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mai ai o incercare!");
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;
            labelTimer.Text = time.ToString();
            if (time <= 0)
            {
                MessageBox.Show("Ai pierdut!", "Ai pierdut!");
                this.Close();
            }
        }

        private void PopQuizGameQuiz_Load(object sender, EventArgs e)
        {
            answerRed.Text = answer1;
            answerGreen.Text = answer2;
            answerBlue.Text = answer3;
            answerYellow.Text = answer4;
        }
    }
}
