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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quizy.Quiz_Form_Template
{
    public partial class FlashMemoryCardGameQuiz : Form
    {
        public int countTime = 120;
        private int rightGuessesToMake = 8;
        public string answer1 { get; set; }
        public string object1 { get; set; }
        public string answer2 { get; set; }
        public string object2 { get; set; }
        public string answer3 { get; set; }
        public string object3 { get; set; }
        public string answer4 { get; set; }
        public string object4 { get; set; }
        public string answer5 { get; set; }
        public string object5 { get; set; }
        public string answer6 { get; set; }
        public string object6 { get; set; }
        public string answer7 { get; set; }
        public string object7 { get; set; }
        public string answer8 { get; set; }
        public string object8 { get; set; }

        private bool isFirst = true;
        Random rand = new Random();

        public bool isFinished = false;

        //a - answer o - object
        public string firstChar = string.Empty;

        private void checkWin()
        {
            rightGuessesToMake--;
            if (rightGuessesToMake == 0)
            {
                MessageBox.Show($"Ai câștigat!", "Ai câștigat!");
                interpretor intr = new interpretor();
                intr.addPoints(100);
            }
        }
        public FlashMemoryCardGameQuiz()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
            richTextBox1.Font = new Font("Microsoft Tai Le", 54);
            richTextBox2.Font = new Font("Microsoft Tai Le", 54);
            richTextBox3.Font = new Font("Microsoft Tai Le", 54);
            richTextBox4.Font = new Font("Microsoft Tai Le", 54);
            richTextBox5.Font = new Font("Microsoft Tai Le", 54);
            richTextBox6.Font = new Font("Microsoft Tai Le", 54);
            richTextBox7.Font = new Font("Microsoft Tai Le", 54);
            richTextBox8.Font = new Font("Microsoft Tai Le", 54);
            richTextBox9.Font = new Font("Microsoft Tai Le", 54);
            richTextBox10.Font = new Font("Microsoft Tai Le", 54);
            richTextBox11.Font = new Font("Microsoft Tai Le", 54);
            richTextBox12.Font = new Font("Microsoft Tai Le", 54);
            richTextBox13.Font = new Font("Microsoft Tai Le", 54);
            richTextBox14.Font = new Font("Microsoft Tai Le", 54);
            richTextBox15.Font = new Font("Microsoft Tai Le", 54);
            richTextBox16.Font = new Font("Microsoft Tai Le", 54);
            richTextBox1.Text = " X";
            richTextBox2.Text = " X";
            richTextBox3.Text = " X";
            richTextBox4.Text = " X";
            richTextBox5.Text = " X";
            richTextBox6.Text = " X";
            richTextBox7.Text = " X";
            richTextBox8.Text = " X";
            richTextBox9.Text = " X";
            richTextBox10.Text = " X";
            richTextBox11.Text = " X";
            richTextBox12.Text = " X";
            richTextBox13.Text = " X";
            richTextBox14.Text = " X";
            richTextBox15.Text = " X";
            richTextBox16.Text = " X";
            timer.Start();
        }

        private void FlashMemoryCardGameQuiz_Load(object sender, EventArgs e)
        {

        }
        private void revertOriginal()
        {
            richTextBox1.Font = new Font("Microsoft Tai Le", 54);
            richTextBox2.Font = new Font("Microsoft Tai Le", 54);
            richTextBox3.Font = new Font("Microsoft Tai Le", 54);
            richTextBox4.Font = new Font("Microsoft Tai Le", 54);
            richTextBox5.Font = new Font("Microsoft Tai Le", 54);
            richTextBox6.Font = new Font("Microsoft Tai Le", 54);
            richTextBox7.Font = new Font("Microsoft Tai Le", 54);
            richTextBox8.Font = new Font("Microsoft Tai Le", 54);
            richTextBox9.Font = new Font("Microsoft Tai Le", 54);
            richTextBox10.Font = new Font("Microsoft Tai Le", 54);
            richTextBox11.Font = new Font("Microsoft Tai Le", 54);
            richTextBox12.Font = new Font("Microsoft Tai Le", 54);
            richTextBox13.Font = new Font("Microsoft Tai Le", 54);
            richTextBox14.Font = new Font("Microsoft Tai Le", 54);
            richTextBox15.Font = new Font("Microsoft Tai Le", 54);
            richTextBox16.Font = new Font("Microsoft Tai Le", 54);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countTime--;
            time.Text = countTime.ToString();
            if (countTime == 0)
            {
                timer.Stop();
                MessageBox.Show("Ai pierdut!", " Ai pierdut!");
                this.Close();
            }
        }

        async private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = answer1;
            richTextBox1.Font = new Font("Microsoft Tai Le", 16);
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a1";
            }
            else
            {
                isFirst = true;
                if (firstChar == "o1")
                {
                    richTextBox1.Visible = false;
                    richTextBox14.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = object2;
            richTextBox2.Font = new Font("Microsoft Tai Le", 16);
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o2";
            }
            else
            {
                isFirst = true;
                if (firstChar == "a2")
                {
                    richTextBox2.Visible = false;
                    richTextBox10.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            richTextBox3.Text = answer6;
            richTextBox3.Font = new Font("Microsoft Tai Le", 19);
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a6";
            }
            else
            {
                isFirst = true;
                if (firstChar == "o6")
                {
                    richTextBox3.Visible = false;
                    richTextBox6.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            richTextBox4.Text = answer7;
            richTextBox4.Font = new Font("Microsoft Tai Le", 16);
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a7";
            }
            else
            {
                isFirst = true;
                if (firstChar == "o7")
                {
                    richTextBox4.Visible = false;
                    richTextBox7.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            richTextBox5.Text = object8;
            richTextBox5.Font = new Font("Microsoft Tai Le", 16);
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o8";
            }
            else
            {
                isFirst = true;
                if (firstChar == "a8")
                {
                    richTextBox5.Visible = false;
                    richTextBox16.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            richTextBox6.Font = new Font("Microsoft Tai Le", 16);
            richTextBox6.Text = object6;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o6";
            }
            else
            {
                isFirst = true;
                if (firstChar == "a6")
                {
                    richTextBox6.Visible = false;
                    richTextBox3.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            richTextBox7.Font = new Font("Microsoft Tai Le", 16);
            richTextBox7.Text = object7;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o7";
            }
            else
            {
                isFirst = true;
                if (firstChar == "a7")
                {
                    richTextBox7.Visible = false;
                    richTextBox4.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
            richTextBox8.Text = answer3;
            richTextBox8.Font = new Font("Microsoft Tai Le", 16);
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a3";
            }
            else
            {
                isFirst = true;
                if (firstChar == "o3")
                {
                    richTextBox8.Visible = false;
                    richTextBox9.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            richTextBox9.Font = new Font("Microsoft Tai Le", 16);
            richTextBox9.Text = object3;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o3";
            }
            else
            {
                isFirst = true;
                if (firstChar == "a3")
                {
                    richTextBox2.Visible = false;
                    richTextBox10.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
            richTextBox10.Font = new Font("Microsoft Tai Le", 16);
            richTextBox10.Text = answer2;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a2";
            }
            else
            {
                isFirst = true;
                if (firstChar == "o2")
                {
                    richTextBox8.Visible = false;
                    richTextBox9.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
            richTextBox11.Font = new Font("Microsoft Tai Le", 16);
            richTextBox11.Text = object5;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o5";
            }
            else
            {
                isFirst = true;
                if (firstChar == "a5")
                {
                    richTextBox11.Visible = false;
                    richTextBox12.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox12_TextChanged(object sender, EventArgs e)
        {
            richTextBox12.Font = new Font("Microsoft Tai Le", 16);
            richTextBox12.Text = answer5;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a5";
            }
            else
            {
                isFirst = true;
                if (firstChar == "o5")
                {
                    richTextBox11.Visible = false;
                    richTextBox12.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox13_TextChanged(object sender, EventArgs e)
        {
            richTextBox13.Font = new Font("Microsoft Tai Le", 16);
            richTextBox13.Text = answer4;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a4";
                checkWin();
            }
            else
            {
                isFirst = true;
                if (firstChar == "o4")
                {
                    richTextBox13.Visible = false;
                    richTextBox15.Visible = false;
                }
                else
                {
                    revertOriginal(); richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox14_TextChanged(object sender, EventArgs e)
        {
            richTextBox14.Font = new Font("Microsoft Tai Le", 16);
            richTextBox14.Text = object1;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o1";
            }
            else
            {
                isFirst = true;
                if (firstChar == "a1")
                {
                    richTextBox1.Visible = false;
                    richTextBox14.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox15_TextChanged(object sender, EventArgs e)
        {
            richTextBox15.Font = new Font("Microsoft Tai Le", 16);
            richTextBox15.Text = object4;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "o4";
                checkWin();
            }
            else
            {
                isFirst = true;
                if (firstChar == "a4")
                {
                    richTextBox13.Visible = false;
                    richTextBox15.Visible = false;
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }

        async private void richTextBox16_TextChanged(object sender, EventArgs e)
        {
            richTextBox16.Font = new Font("Microsoft Tai Le", 16);
            richTextBox16.Text = answer8;
            await Task.Delay(500);
            if (isFirst)
            {
                isFirst = false;
                firstChar = "a8";
            }
            else
            {
                isFirst = true;
                if (firstChar == "o8")
                {
                    richTextBox5.Visible = false;
                    richTextBox16.Visible = false;
                    checkWin();
                }
                else
                {
                    revertOriginal();
                    richTextBox1.Text = " X";
                    richTextBox2.Text = " X";
                    richTextBox3.Text = " X";
                    richTextBox4.Text = " X";
                    richTextBox5.Text = " X";
                    richTextBox6.Text = " X";
                    richTextBox7.Text = " X";
                    richTextBox8.Text = " X";
                    richTextBox9.Text = " X";
                    richTextBox10.Text = " X";
                    richTextBox11.Text = " X";
                    richTextBox12.Text = " X";
                    richTextBox13.Text = " X";
                    richTextBox14.Text = " X";
                    richTextBox15.Text = " X";
                    richTextBox16.Text = " X";
                }
            }
        }
    }
}
