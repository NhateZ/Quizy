using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizy.class_for_firestore
{
    [FirestoreData]
    public class ClassMemory
    {
        [FirestoreProperty]
        public string Question1 { get; set; }
        [FirestoreProperty]
        public string Answer1 { get; set; }
        [FirestoreProperty]
        public string Question2 { get; set; }
        [FirestoreProperty]
        public string Answer2 { get; set; }
        [FirestoreProperty]
        public string Queston3 { get; set; }
        [FirestoreProperty]
        public string Answer3 { get; set; }
        [FirestoreProperty]
        public string Question4 { get; set; }
        [FirestoreProperty]
        public string Answer4 { get; set; }
        [FirestoreProperty]
        public string Question5 { get; set; }
        [FirestoreProperty]
        public string Answer5 { get; set; }
        [FirestoreProperty]
        public string Question6 { get; set; }
        [FirestoreProperty]
        public string Answer6 { get; set; }
        [FirestoreProperty]
        public string Question7 { get; set; }
        [FirestoreProperty]
        public string Answer7 { get; set; }
        [FirestoreProperty]
        public string Question8 { get; set; }
        [FirestoreProperty]
        public string Answer8 { get;set; }
    }
}
