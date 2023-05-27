using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizy.class_for_firestore
{
    [FirestoreData]
    public class ClassSnake
    {
        [FirestoreProperty]
        public int RequiredScore {get; set; }
        [FirestoreProperty]
        public int Increment { get; set; }
        [FirestoreProperty]
        public int Time { get; set; }
    }
}
