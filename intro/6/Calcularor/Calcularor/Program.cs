using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("첫번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            double number1 = double.Parse(userInput1);
            Console.WriteLine("두번째 숫자를 입력하세요");
            string userInput2 = Console.ReadLine();
            double number2 = double.Parse(userInput2);
            Console.WriteLine("연산자를 입력하세요");
            string inputOperator =Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperator);
            Console.Write(number2);
            Console.Write("=");

            if (inputOperator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (inputOperator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (inputOperator == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (inputOperator == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            else if (inputOperator == "%")
            {
                Console.WriteLine(number1 % number2);
             }
            else
            {
                Console.WriteLine("잘못 입력 하셨습니다.");
            }
        }
    }
}

