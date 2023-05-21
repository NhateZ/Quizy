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
        public string[] WordCollection = new string[8];
        public string GuessWord { get; set; }
        public int Mistake = 0;

        public GhicitoareaGameQuiz()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
        }

        private void GhicitoareaGameQuiz_Load(object sender, EventArgs e)
        {
            /*
             * 
             * Insert Database...
            */
            Random randomNumber = new Random();
            GuessWord = WordCollection[randomNumber.NextInt64(0, 7)];

            for(int i = 12;i <= 12-GuessWord.Length;i++) 
            {
                HideLabel(i);
            }
           




        }
        private void HideLabel(int index)
        {
            switch (index)
            {
                case 1:
                    label1.Visible= false;
                break;
                case 2:
                    label2.Visible= false;
                break;
                case 3:
                    label3.Visible= false;
                break;
                case 4:
                    label4.Visible= false;
                break;
                case 5:
                    label5.Visible= false;  
                break;
                case 6:
                    label6.Visible= false;
                break;
                case 7:
                    label7.Visible= false;
                break;
                case 8:
                    label8.Visible = false;
                break;
                case 9:
                    label9.Visible= false;
                break;
                case 10:
                    label10.Visible= false;
                break;
                case 11:
                    label11.Visible= false;
                break;
                case 12:
                    label12.Visible= false;
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
        }
        private void ChangeStateMisake(int mistakes)
        {
            switch(mistakes)
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
                break;
            }

        }

        private void pictureBoxA_Click(object sender, EventArgs e)
        {
            if(GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for(int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxB_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('b') || GuessWord.Contains('B'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'b' || GuessWord[i] == 'B')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxC_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxD_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxE_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxF_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxG_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxH_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxI_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxJ_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxK_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxL_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxM_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxN_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxO_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxP_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxQ_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxR_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxS_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxT_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxU_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxV_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxW_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxX_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxY_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }

        private void pictureBoxZ_Click(object sender, EventArgs e)
        {
            if (GuessWord.Contains('a') || GuessWord.Contains('A'))
            {
                for (int i = 0; i <= GuessWord.Length - 1; i++)
                {
                    if (GuessWord[i] == 'a' || GuessWord[i] == 'A')
                    {
                        ShowLetter(i, GuessWord[i]);
                    }
                }
            }
            else
            {
                Mistake++;
                ChangeStateMisake(Mistake);
            }
        }
    }
}
