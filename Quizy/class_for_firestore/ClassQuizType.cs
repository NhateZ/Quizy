using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizy.class_for_firestore
{
    [FirestoreData]
    public class ClassQuizType
    {
        [FirestoreProperty]
        public int typeOfQuiz { get; set; }
        
    }
}
