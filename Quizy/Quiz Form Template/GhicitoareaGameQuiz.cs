using Quizy.program_interpretor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy.Quiz_Form_Template
{
    public partial class GhicitoareaGameQuiz : Form
    {
        public string word1;
        public string word2;
        public string word3;
        public string word4;
        public string GuessWord { get; set; }
        public int Mistake = 0;
        public int Correct = 0;
        public int point = 100;
        public int numberOfWords { get; set; }
        public bool isFinished = false;

        public GhicitoareaGameQuiz()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
        }

        private void GhicitoareaGameQuiz_Load(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int mem = randomNumber.Next(1, 5);
            switch (mem)
            {
                case 1:
                    GuessWord = word1;
                    break;
                case 2:
                    GuessWord = word2;
                    break;
                case 3:
                    GuessWord = word3;
                    break;
                case 4:
                    GuessWord = word4;
                    break;
                default:
                    GuessWord = word1;
                    break;

            }
            for (int i = 12; i > GuessWord.Length; i--)
            {
                HideLabel(i);
            }





        }
        private void HideLabel(int index)
        {
            switch (index)
            {
                case 1:
                    label1.Visible = false;
                    break;
                case 2:
                    label2.Visible = false;
                    break;
                case 3:
                    label3.Visible = false;
                    break;
                case 4:
                    label4.Visible = false;
                    break;
                case 5:
                    label5.Visible = false;
                    break;
                case 6:
                    label6.Visible = false;
                    break;
                case 7:
                    label7.Visible = false;
                    break;
                case 8:
                    label8.Visible = false;
                    break;
                case 9:
                    label9.Visible = false;
                    break;
                case 10:
                    label10.Visible = false;
                    break;
                case 11:
                    label11.Visible = false;
                    break;
                case 12:
                    label12.Visible = false;
                    break;

            }
        }
        private void ShowLetter(int index, char c)
        {
            switch (index)
            {
                case 1:
                    label1.Text = c.ToString();
                    break;
                case 2:
                    label2.Text = c.ToString();
                    break;
                case 3:
                    label3.Text = c.ToString();
                    break;
                case 4:
                    label4.Text = c.ToString();
                    break;
                case 5:
                    label5.Text = c.ToString();
                    break;
                case 6:
                    label6.Text = c.ToString();
                    break;
                case 7:
                    label7.Text = c.ToString();
                    break;
                case 8:
                    label8.Text = c.ToString();
                    break;
                case 9:
                    label9.Text = c.ToString();
                    break;
                case 10:
                    label10.Text = c.ToString();
                    break;
                case 11:
                    label11.Text = c.ToString();
                    break;
                case 12:
                    label12.Text = c.ToString();
                    break;

            }
            Correct++;
            if (Correct == GuessWord.Length)
            {
                MessageBox.Show($"Ai câștigat!\nAi obținut {point}  puuncte", "Ai câștigat!");
                interpretor intr = new interpretor();
                if (Mistake != 0)
                    intr.addPoints(100 / Mistake);
                else if (Mistake == 0)
                    intr.addPoints(100);

            }
        }
        private void ChangeStateMisake(int mistakes)
        {
            switch (mistakes)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:
                    //game Over;
                    MessageBox.Show("Ai pierdut!", "Ai pierdut!");
                    break;
            }
            point -= 15;
        }

        private void pictureBoxA_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxA.Visible = false;
        }

        private void pictureBoxB_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('b') || GuessWord.Contains('B'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'b' || GuessWord[i] == 'B')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxB.Visible = false;
        }

        private void pictureBoxC_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('c') || GuessWord.Contains('C'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'c' || GuessWord[i] == 'C')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxC.Visible = false;
        }

        private void pictureBoxD_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('d') || GuessWord.Contains('D'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'd' || GuessWord[i] == 'D')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxD.Visible = false;
        }

        private void pictureBoxE_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('e') || GuessWord.Contains('E'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'e' || GuessWord[i] == 'E')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxE.Visible = false;
        }

        private void pictureBoxF_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('f') || GuessWord.Contains('F'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'f' || GuessWord[i] == 'F')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxF.Visible = false;
        }

        private void pictureBoxG_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('g') || GuessWord.Contains('G'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'g' || GuessWord[i] == 'G')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxG.Visible = false;
        }

        private void pictureBoxH_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('h') || GuessWord.Contains('H'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'h' || GuessWord[i] == 'H')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxH.Visible = false;
        }

        private void pictureBoxI_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('i') || GuessWord.Contains('I'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'i' || GuessWord[i] == 'I')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxI.Visible = false;
        }

        private void pictureBoxJ_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('j') || GuessWord.Contains('J'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'j' || GuessWord[i] == 'J')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxJ.Visible = false;
        }

        private void pictureBoxK_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('k') || GuessWord.Contains('K'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'k' || GuessWord[i] == 'K')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxK.Visible = false;
        }

        private void pictureBoxL_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('l') || GuessWord.Contains('L'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'l' || GuessWord[i] == 'L')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
                pictureBoxL.Visible = false;
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxM_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('m') || GuessWord.Contains('M'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'm' || GuessWord[i] == 'M')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxM.Visible = false;
        }

        private void pictureBoxN_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('n') || GuessWord.Contains('N'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'n' || GuessWord[i] == 'N')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxN.Visible = false;
        }

        private void pictureBoxO_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('o') || GuessWord.Contains('O'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'o' || GuessWord[i] == 'O')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxO.Visible = false;
        }

        private void pictureBoxP_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('p') || GuessWord.Contains('P'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'p' || GuessWord[i] == 'P')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxP.Visible = false;
        }

        private void pictureBoxQ_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('q') || GuessWord.Contains('Q'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'q' || GuessWord[i] == 'Q')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxQ.Visible = false;
        }

        private void pictureBoxR_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('r') || GuessWord.Contains('R'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'r' || GuessWord[i] == 'R')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxR.Visible = false;
        }

        private void pictureBoxS_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('s') || GuessWord.Contains('S'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 's' || GuessWord[i] == 'S')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxS.Visible = false;
        }

        private void pictureBoxT_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('t') || GuessWord.Contains('T'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 't' || GuessWord[i] == 'T')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxT.Visible = false;
        }

        private void pictureBoxU_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('u') || GuessWord.Contains('U'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'u' || GuessWord[i] == 'U')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxU.Visible = false;
        }

        private void pictureBoxV_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('v') || GuessWord.Contains('V'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'v' || GuessWord[i] == 'V')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxV.Visible = false;
        }

        private void pictureBoxW_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('w') || GuessWord.Contains('W'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'w' || GuessWord[i] == 'W')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxW.Visible = false;
        }

        private void pictureBoxX_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('x') || GuessWord.Contains('X'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'x' || GuessWord[i] == 'X')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxX.Visible = false;
        }

        private void pictureBoxY_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('y') || GuessWord.Contains('Y'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'y' || GuessWord[i] == 'Y')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxY.Visible = false;
        }

        private void pictureBoxZ_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('z') || GuessWord.Contains('Z'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'z' || GuessWord[i] == 'Z')
                    {
                        ShowLetter(i + 1, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
            pictureBoxZ.Visible = false;
        }
    }
}
