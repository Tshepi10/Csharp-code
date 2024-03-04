using System;

class QuizGame
{
    static void Main(string [] args)
    {

    Console.WriteLine("Welcome to the Quiz Game!");

    int  totalMarks = 0;

    totalMarks += AskQuestion("What is the capital of France?","Paris");
    totalMarks += AskQuestion("What is the largest planet in our solar system?","Jupiter");
    totalMarks += AskQuestion("Who wrote 'Romeo and Juliet'?","William Shakespeare");

    Console.WriteLine($"\nQuiz completed! Your total marks: {totalMarks}");

    Console.ReadLine(); 
    }//main method

    static int AskQuestion(string question,string correctAnswer)
{
    Console.WriteLine("\n" + question);

    Console.WriteLine("Your Answer: ");
    string userAnswer = Console.ReadLine();

return 1;   
    }
}


        


