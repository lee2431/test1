using System;

namespace hardtest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 확인하고자 하는 수를 입력하세요.");
            int number = int.Parse(Console.ReadLine());
            int number2 = number % 3;
            if (number2 == 0 && number > 20) { // 참, 거짓은 참 거짓으로만 묶어야 한다. &&은 참 거짓만 판단 할 수 있다.
                
                    Console.WriteLine("20보다 큰 3의 배수 입니다."); }
            else { Console.WriteLine("20보다 작고 3의 배수가 아닙니다."); }
                
            }
        }
    }
