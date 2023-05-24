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
        public short RightAnswer { get; set; }
        /*
         * 0 - Red
         * 1 - Green
         * 2 - Blue
         * 3 - Yellow
        */
        public int Time = 100;
        public bool isFinished = false;

        public PopQuizGameQuiz()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
            labelTimer.Text = Time.ToString();
        }

        private void answerRed_Click(object sender, EventArgs e)
        {
            if (RightAnswer == 0)
            {

            }
            else
            {

            }
        }

        private void answerGreen_Click(object sender, EventArgs e)
        {
            if (RightAnswer == 1)
            {

            }
            else
            {

            }
        }

        private void answerBlue_Click(object sender, EventArgs e)
        {
            if (RightAnswer == 2)
            {

            }
            else
            {

            }
        }

        private void answerYellow_Click(object sender, EventArgs e)
        {
            if (RightAnswer == 3)
            {

            }
            else
            {

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Time--;
            labelTimer.Text= Time.ToString();
        }
    }
}
