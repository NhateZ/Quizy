using Quizy.Quiz_Form_Template;
using Quizy.Quiz_Form_Template.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
namespace Quizy.program_interpretor
{
    internal class interpretor
    {
        //Firestore Variables
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"quizydatabase-190702-firebase-adminsdk-zvidg-66d9302bb8.json";
        FirestoreDb db = FirestoreDb.Create("quizydatabase-190702");
        //header variables

        //the number of questions it has
        public int pages;

        //the password you need to put to exit the program for the final score
        public int exitpass;

        /* 1 - Snake
         * 2 - Guesstheword
         * 3 - Popquiz
         * 4 - FlashMemoryCard
         */
        private int typeOfQuiz;

        
        public void startInterpretor()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            for (int i = 1; i <= pages; i++)
            {
                if (typeOfQuiz == 1)
                {
                    SnakeGame snakeGame = new SnakeGame();
                    snakeGame.Show();
                    while (!snakeGame.isFinished) { }

                }
                else if (typeOfQuiz == 2)
                {

                    GhicitoareaGameQuiz ghicitoareaGame  = new GhicitoareaGameQuiz();
                    ghicitoareaGame.Show();
                    while (!ghicitoareaGame.isFinished) { }
                }
                else if (typeOfQuiz == 3)
                {

                    PopQuizGameQuiz popQuizGame= new PopQuizGameQuiz();
                    popQuizGame.Show();
                    while (!popQuizGame.isFinished) { }
                }
                else if (typeOfQuiz == 4)
                {

                    FlashMemoryCardGameQuiz flashMemory = new FlashMemoryCardGameQuiz();
                    flashMemory.Show();
                    while (!flashMemory.isFinished) { }
                }


            }
        }
    }
}
