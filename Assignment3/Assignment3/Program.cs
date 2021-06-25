using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Total size of the array that holds the answers.
            int SIZE = 20;
            // Answers in a list.
            char[] answers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 
            'D', 'C', 'C', 'B', 'D', 'A'};

            char [] userAnswer = new char [SIZE];

            // Initializing the number correct and wrong to 0.
            int numberCorrect = 0;
            int numberWrong = 0;

            for(int x = 0; x < SIZE; x++)
            {
                Console.WriteLine("Enter Question {0} answer: ", x +1);
                // Read the user input
                userAnswer[x] = char.Parse(Console.ReadLine());

                if(answers[x] != userAnswer[x])
                {
                    numberWrong++;
                }
                    else
                    {
                        numberCorrect++;
                    }

            }
                    // If the user has less than the 15 required correct answers they fail.
                    if(numberCorrect >= 15)
                    {
                        Console.WriteLine("\nYou passed!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou failed...");
                    }
                    Console.WriteLine("\nTotal number of questions answered correctly: {0}", numberCorrect);
                    Console.WriteLine("\nTotal number of questions answered incorrectly: {0}", numberWrong);
                    // Output to screen wrongly answered questions.
                    Console.WriteLine("\nQuestions you have incorrectly answered: ");

                    for(int x = 0; x < SIZE; x++)
                    {

                        if(userAnswer[x] != answers[x])
                        {
                            Console.WriteLine("Question {0}", (x + 1));
                        }

                    }
                    Console.ReadKey();
            
        }
    }
}

