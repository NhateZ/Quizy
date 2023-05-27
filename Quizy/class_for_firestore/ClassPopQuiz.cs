using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizy.class_for_firestore
{
    [FirestoreData]
    public class ClassPopQuiz
    {
        [FirestoreProperty]
        public string question { get; set; }
        [FirestoreProperty]
        public string AnswerRed { get; set; }
        [FirestoreProperty]
        public string AnswerGreen { get; set; }
        [FirestoreProperty]
        public string AnswerBlue { get; set; }
        [FirestoreProperty]
        public string AnswerYellow { get; set; }
        [FirestoreProperty]
        public string RightAnswer { get; set; }
        [FirestoreProperty]
        public int Time { get; set; }
    }
}
