using Quizy.Quiz_Form_Template;
using Quizy.Quiz_Form_Template.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Quizy.class_for_firestore;
using System.Security.Cryptography;

namespace Quizy.program_interpretor
{
    internal class interpretor
    {
        //Firestore Variables
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"program_interpretor\quizydatabase-190702-firebase-adminsdk-zvidg-66d9302bb8.json";
        
        //header variables
        public string _id { get; set; }
        //the number of questions it has
        public int pages;
        public int points;

        /* 1 - Snake
         * 2 - Guesstheword
         * 3 - Popquiz
         * 4 - FlashMemoryCard
         */
        private int typeOfQuiz;
        
        
        public async void startInterpretor(string idmem)
        {
            _id = idmem;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
            DocumentReference docHeader = db.Collection("quizy").Document(_id).Collection("data").Document("Header");
            DocumentSnapshot docSnap = await docHeader.GetSnapshotAsync();
            if(docSnap.Exists)
            {
                ClassHeader header = docSnap.ConvertTo<ClassHeader>();
                pages = header.pages;
            }            
            for (int i = 1; i <= pages; i++)
            {
                DocumentReference docType = db.Collection("quizy").Document(_id).Collection("data").Document($"{i}_type");
                DocumentSnapshot docSnap1 = await docType.GetSnapshotAsync();
                if (docSnap1.Exists)
                {
                    ClassQuizType cQuiztType = docSnap1.ConvertTo<ClassQuizType>();
                    typeOfQuiz = cQuiztType.typeOfQuiz;
                }
                
                if (typeOfQuiz == 1)
                {
                    DocumentReference doc = db.Collection("quizy").Document(_id).Collection("data").Document(i.ToString());
                    DocumentSnapshot dSnap = await doc.GetSnapshotAsync();
                    SnakeGame snakeGame = new SnakeGame();
                    if (dSnap.Exists)
                    {
                        ClassSnake classSnake = dSnap.ConvertTo<ClassSnake>();
                        snakeGame.increment = classSnake.Increment;
                        snakeGame.time = classSnake.Time;
                        snakeGame.requiredScore = classSnake.RequiredScore;
                    }
                    snakeGame.ShowDialog();

                }
                else if (typeOfQuiz == 2)
                {
                    DocumentReference doc = db.Collection("quizy").Document(_id).Collection("data").Document(i.ToString());
                    DocumentSnapshot dSnap = await doc.GetSnapshotAsync();
                    GhicitoareaGameQuiz ghicitoareaGame  = new GhicitoareaGameQuiz();
                    if (dSnap.Exists)
                    {
                        ClassGuess classGuess = dSnap.ConvertTo<ClassGuess>();
                        ghicitoareaGame.word1 = classGuess.Word1;
                        ghicitoareaGame.word2 = classGuess.Word2;
                        ghicitoareaGame.word3 = classGuess.Word3;
                        ghicitoareaGame.word4 = classGuess.Word4;
                    }
                    ghicitoareaGame.ShowDialog();                
                }
                else if (typeOfQuiz == 3)
                {
                    DocumentReference doc = db.Collection("quizy").Document(_id).Collection("data").Document(i.ToString());
                    DocumentSnapshot dSnap = await doc.GetSnapshotAsync();
                    PopQuizGameQuiz popQuizGame= new PopQuizGameQuiz();
                    if (dSnap.Exists)
                    {
                        ClassPopQuiz classPop = dSnap.ConvertTo<ClassPopQuiz>();
                        popQuizGame.answer1 = classPop.AnswerRed;
                        popQuizGame.answer2 = classPop.AnswerGreen;
                        popQuizGame.answer3 = classPop.AnswerBlue;
                        popQuizGame.answer4 = classPop.AnswerYellow;
                        popQuizGame.question = classPop.question;
                        popQuizGame.time = classPop.Time;
                        if (classPop.RightAnswer.ToLower() == "red")
                            popQuizGame.rightAnswer = 0;
                        else if (classPop.RightAnswer.ToLower() == "green")
                            popQuizGame.rightAnswer = 1;
                        else if (classPop.RightAnswer.ToLower() == "blue")
                            popQuizGame.rightAnswer = 2;
                        else if (classPop.RightAnswer.ToLower() == "yellow")
                            popQuizGame.rightAnswer = 3;
                    }
                    popQuizGame.ShowDialog();
                }
                else if (typeOfQuiz == 4)
                {
                    DocumentReference doc = db.Collection("quizy").Document(_id).Collection("data").Document(i.ToString());
                    DocumentSnapshot dSnap = await doc.GetSnapshotAsync();
                    FlashMemoryCardGameQuiz flashMemory = new FlashMemoryCardGameQuiz();
                    if (dSnap.Exists)
                    {
                        ClassMemory classMemory = dSnap.ConvertTo<ClassMemory>();
                        flashMemory.answer1 = classMemory.Answer1;
                        flashMemory.answer2 = classMemory.Answer2;
                        flashMemory.answer3 = classMemory.Answer3;
                        flashMemory.answer4 = classMemory.Answer4;
                        flashMemory.answer5 = classMemory.Answer5;
                        flashMemory.answer6 = classMemory.Answer6;
                        flashMemory.answer7 = classMemory.Answer7;
                        flashMemory.answer8 = classMemory.Answer8;
                        flashMemory.object1 = classMemory.Question1;
                        flashMemory.object2 = classMemory.Question2;
                        flashMemory.object3 = classMemory.Queston3;
                        flashMemory.object4 = classMemory.Question4;
                        flashMemory.object5 = classMemory.Question5;
                        flashMemory.object6 = classMemory.Question6;
                        flashMemory.object7 = classMemory.Question7;
                        flashMemory.object8 = classMemory.Question8;
                        
                    }
                    flashMemory.ShowDialog();                
                }
            }
            MessageBox.Show($"Felicitari!\nAi obtinut {points/pages} puncte!", "Felicitari");
        }
        public void addPoints(int x)
        {
            points += x;
        }
    }
}
