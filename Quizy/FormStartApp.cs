using Quizy.Forms_Derived_From_Start_Form;
using Quizy.Quiz_Form_Template;
using Quizy.Quiz_Form_Template.Snake;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace Quizy
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
        }

        private void pictureBoxMainQuiz_Click(object sender, EventArgs e)
        {
            FormMainQuiz formMainQuiz = new FormMainQuiz();
            this.Hide();
            formMainQuiz.Closed += (s, args) => this.Close(); 
            formMainQuiz.Show();
        }

        private void pictureBoxCustomQuiz_Click(object sender, EventArgs e)
        {
            /*SnakeGame snakeGame= new SnakeGame();
            this.Hide();
            snakeGame.Closed += (s, args) => this.Close();
            snakeGame.Show();*/
            PopQuizGameQuiz snakeGame = new PopQuizGameQuiz();
            this.Hide();
            snakeGame.Closed += (s, args) => this.Close();
            snakeGame.Show();
        }

        private void pictureBoxCustomQuizCreator_Click(object sender, EventArgs e)
        {
            FormCustomQuizCreator formCustomQuizCreator = new FormCustomQuizCreator();
            this.Hide();
            formCustomQuizCreator.Closed += (s, args) => this.Close();
            formCustomQuizCreator.Show();
        }

        private void pictureBoxTutorialCustomQuiz_Click(object sender, EventArgs e)
        {

        }
    }
}