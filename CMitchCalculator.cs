using System;

namespace addition
{

    class Program
    {
        //About App:

        //Non Technical Shit:

        //This is a calculator made by CMitch213
        //Feel free to use this for personal use
        //If you use this make sure to credit me <3


        //Technical Shit:

        //This was written in C# as a Console Application
        //The version of .Net Core I wrote this on is 3.1.10
        //I wrote this in Microsoft Visual Studio 2019
        

        
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double answer;
            bool operatorSet = false;
            int operationNum = 0;

            Console.WriteLine("------     CMitch's Text Based Calculator     ------     -v1.12-");
            firstNumber();
            operation();
            secondNumber();
            mathShit();

            void firstNumber()
            {
                Console.WriteLine("Input your first number:");

                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Your first number is: " + num1);
            }

            void operation()
            {
                while (operatorSet == false)
                {
                    Console.Clear();
                    Console.WriteLine("Input your operator:");
                    Console.WriteLine("");
                    Console.WriteLine("1 for addition");
                    Console.WriteLine("2 for subtrafction");
                    Console.WriteLine("3 for multiplication");
                    Console.WriteLine("4 for division");
                    Console.WriteLine("");


                    var input = Console.ReadKey().KeyChar;

                    if (input == '1')
                    {
                        operationNum = 1;
                        Console.WriteLine("You chose: Addition!");
                        operatorSet = true;
                    }
                    else if (input == '2')
                    {
                        operationNum = 2;
                        Console.WriteLine("You chose: Subtraction!");
                        operatorSet = true;
                    }
                    else if (input == '3')
                    {
                        operationNum = 3;
                        Console.WriteLine("You chose: Multiplication!");
                        operatorSet = true;
                    }
                    else if (input == '4')
                    {
                        operationNum = 4;
                        Console.WriteLine("You chose: Division!");
                        operatorSet = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Invalid Input, Try one of the actual options shithead");
                    }
                }
            }

            void secondNumber()
            {
                Console.Clear();
                Console.WriteLine("Input your second number:");

                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Your second number is: " + num2);
            }
            
            void mathShit()
            {
                if(operationNum == 1)
                {
                    answer = num1 + num2;
                    Console.Clear();
                    Console.WriteLine("The answer is " + answer);
                }
                else if(operationNum == 2)
                {
                    answer = num1 - num2;
                    Console.Clear();
                    Console.WriteLine("The answer is " + answer);
                }
                else if(operationNum == 3)
                {
                    answer = num1 * num2;
                    Console.Clear();
                    Console.WriteLine("The answer is " + answer);
                }
                else if(operationNum == 4)
                {
                    answer = num1 / num2;
                    Console.Clear();
                    Console.WriteLine("The answer is " + answer);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR: Honestly bro idfk, if you're reading this that means that there isnt an operator.");
                }
            }
        }
    }
}
