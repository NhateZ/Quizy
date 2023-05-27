using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy.Forms_Derived_From_Start_Form
{
    public partial class FormCustomQuizCreator : Form
    {
        //firestore Variables
        private int nrPages;
        private string _id;
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"program_interpretor\quizydatabase-190702-firebase-adminsdk-zvidg-66d9302bb8.json";
        public FormCustomQuizCreator()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
        }

        private void pictureBoxBackArrow1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxBackArrow2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxBackArrow3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxBackArrow4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUploadSnake_Click(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            try
            {
                nrPages++;
                DocumentReference document = db.Collection("quizy").Document(_id).Collection("data").Document(nrPages.ToString());
                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"RequiredScore", Convert.ToInt32(textBoxRequiredScore.Text) },
                    {"Increment", Convert.ToInt32(textBoxIncrement.Text) },
                    {"Time", Convert.ToInt32(textBoxTime.Text) }
                };
                document.SetAsync(data);
                MessageBox.Show("Datele au fost introduse in quiz");
                updateFireStoreDB();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Asigura-te ca toate valorile sunt de tipul potrivit!!");
            }
            DocumentReference document1 = db.Collection("quizy").Document(_id).Collection("data").Document($"{nrPages}_type");
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                    {"typeOfQuiz", 1 }
            };
            document1.SetAsync(data1);
        }

        async private void FormCustomQuizCreator_Load(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"test",1234 }
            };
            DocumentReference doc = await db.Collection("quizy").AddAsync(data);
            _id = doc.Id;
            DocumentReference doc2 = db.Collection("quizy").Document(_id).Collection("data").Document("Header");
            data = new Dictionary<string, object>
            {
                {"pages", nrPages}
            };
            doc2.SetAsync(data);
            MessageBox.Show($"Id-ul quizului este: {_id}\nVa rugam frumos sa vi-l notati undeva!", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label15.Text = "Id quiz: " + _id;
            label16.Text = "Id quiz: " + _id;
            label17.Text = "Id quiz: " + _id;
            label18.Text = "Id quiz: " + _id;
        }

        private void buttonPopUpload_Click(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            try
            {
                nrPages++;
                DocumentReference document = db.Collection("quizy").Document(_id).Collection("data").Document(nrPages.ToString());
                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"question",  textBox27.Text},
                    {"AnswerRed",  textBox1.Text},
                    {"AnswerGreen", textBox2.Text },
                    {"AnswerBlue", textBox3.Text},
                    {"AnswerYellow",textBox4.Text },
                    {"RightAnswer",textBox5.Text },
                    {"Time", Convert.ToInt32(textBox6.Text) }
                };
                document.SetAsync(data);
                MessageBox.Show("Datele au fost introduse in quiz");
                updateFireStoreDB();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Asigura-te ca toate valorile sunt de tipul potrivit!!");
            }
            DocumentReference document1 = db.Collection("quizy").Document(_id).Collection("data").Document($"{nrPages}_type");
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                    {"typeOfQuiz", 3 }
            };
            document1.SetAsync(data1);
        }

        private void buttonUploadGuess_Click(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            try
            {
                nrPages++;
                DocumentReference document = db.Collection("quizy").Document(_id).Collection("data").Document(nrPages.ToString());
                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"Word1", textBox7.Text},
                    {"Word2", textBox8.Text },
                    {"Word3", textBox9.Text},
                    {"Word4", textBox10.Text }
                };
                document.SetAsync(data);
                MessageBox.Show("Datele au fost introduse in quiz");
                updateFireStoreDB();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Asigura-te ca toate valorile sunt de tipul potrivit!!");
            }
            DocumentReference document1 = db.Collection("quizy").Document(_id).Collection("data").Document($"{nrPages}_type");
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                    {"typeOfQuiz", 2 }
            };
            document1.SetAsync(data1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            try
            {
                nrPages++;
                DocumentReference document = db.Collection("quizy").Document(_id).Collection("data").Document(nrPages.ToString());
                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"Question1", textBox11.Text},
                    {"Answer1", textBox12.Text },
                    {"Question2", textBox13.Text},
                    {"Answer2", textBox14.Text },
                    {"Question3", textBox11.Text},
                    {"Answer3", textBox12.Text },
                    {"Question4", textBox13.Text},
                    {"Answer4", textBox14.Text },
                    {"Question5", textBox15.Text},
                    {"Answer5", textBox16.Text },
                    {"Question6", textBox17.Text},
                    {"Answer6", textBox18.Text },
                    {"Question7", textBox19.Text},
                    {"Answer7", textBox20.Text },
                    {"Question8", textBox21.Text},
                    {"Answer8", textBox22.Text }
                };
                document.SetAsync(data);
                MessageBox.Show("Datele au fost introduse in quiz");
                updateFireStoreDB();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Asigura-te ca toate valorile sunt de tipul potrivit!!");
            }
            DocumentReference document1 = db.Collection("quizy").Document(_id).Collection("data").Document($"{nrPages}_type");
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                    {"typeOfQuiz", 4 }
            };
            document1.SetAsync(data1);
        }
        async private void updateFireStoreDB()
        {
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            DocumentReference document = db.Collection("quizy")
                .Document(_id)
                .Collection("data")
                .Document("Header");
            DocumentSnapshot docsnap = await document.GetSnapshotAsync();
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"pages",nrPages }
            };
            if (docsnap.Exists)
            {
                await document.SetAsync(data);
            }

        }
    }
}
