using System;
using System.Collections.Generic;

namespace _7._9._Studio_FunWithQuizzes
{
    

    public class Question
    {
        private string Quest { get; set; }
        private Dictionary<string, bool> Answers = new Dictionary<string, bool>();
        private int NumberOfAnswers { get; set; }

    }

    public class MultipleChoice : Question
    {
        
    }

    public class Quiz
    {
        private Dictionary<string, Question> Test = new Dictionary<string, Question>();

        public void RunQuiz()
        {
            //loop through all questions
            //and display each question
            //Display the answer choices for each question.
            //User selects answer

            //Show correct answer


        }
        public void DisplayQuest()
        {

        }
        public void DisplayAnswerChoices()
        {

        }

        private static void DisplayCorrectAnswer(Dictionary<string, bool> answers)
        {
            foreach (KeyValuePair<string, bool> kvp in answers)
            {
                //Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);

                if (kvp.Value == true)
                {
                    Console.WriteLine($"{kvp.Key} is the correct answer");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_7._9._Studio_FunWithQuizzes");
            Console.WriteLine($"Welcome to the Quiz. Type \"Start\" to begin the quiz. ");
            
            var Answers = new Dictionary<string, bool>();
            Answers.Add("True", true);
            Answers.Add("False", false);

            DisplayCorrectAnswer(answers);
            
        }

        
    }
}