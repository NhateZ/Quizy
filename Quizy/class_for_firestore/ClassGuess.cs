using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizy.class_for_firestore
{
    [FirestoreData]
    public class ClassGuess
    {
        [FirestoreProperty]
        public string Word1 { get; set; }
        [FirestoreProperty]
        public string Word2 { get; set; }
        [FirestoreProperty]
        public string Word3 { get; set; }
        [FirestoreProperty]
        public string Word4 { get; set; }
    }
}
