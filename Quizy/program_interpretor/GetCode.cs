using Google.Cloud.Firestore;
using Quizy.class_for_firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy.program_interpretor
{
    public partial class GetCode : Form
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"program_interpretor\quizydatabase-190702-firebase-adminsdk-zvidg-66d9302bb8.json";
        public GetCode()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Program_Icon;
        }

        private async void buttonOpen_Click(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            interpretor interpretor = new interpretor();
            DocumentReference doc = db.Collection("quizy").Document(textBoxCode.Text);
            DocumentSnapshot docSnap = await doc.GetSnapshotAsync();
            if (docSnap.Exists)
            {
                interpretor.startInterpretor(textBoxCode.Text);
                this.Hide();
            }
            else
                MessageBox.Show("Introdu un cod valabil!", "Cod nevalabil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
