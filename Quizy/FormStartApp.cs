using Quizy.Forms_Derived_From_Start_Form;
using Quizy.Quiz_Form_Template;
using Quizy.Quiz_Form_Template.Snake;
using Quizy.program_interpretor;
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
            formMainQuiz.Closed += (s, args) => this.Show();
            formMainQuiz.Show();
        }

        private void pictureBoxCustomQuiz_Click(object sender, EventArgs e)
        {
            GetCode getCode = new GetCode();
            getCode.ShowDialog();
            //snakeGame.Closed += (s, args) => this.Close();
        }

        private void pictureBoxCustomQuizCreator_Click(object sender, EventArgs e)
        {
            FormCustomQuizCreator formCustomQuizCreator = new FormCustomQuizCreator();
            this.Hide();
            formCustomQuizCreator.Closed += (s, args) => this.Show();
            formCustomQuizCreator.Show();
        }

        private void pictureBoxTutorialCustomQuiz_Click(object sender, EventArgs e)
        {

        }

    }
}