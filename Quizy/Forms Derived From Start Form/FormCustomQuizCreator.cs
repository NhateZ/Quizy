using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy.Forms_Derived_From_Start_Form
{
    public partial class FormCustomQuizCreator : Form
    {
        //firestore Variables
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"quizydatabase-190702-firebase-adminsdk-zvidg-66d9302bb8.json";
        FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");

        public FormCustomQuizCreator()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
        }
    }
}
