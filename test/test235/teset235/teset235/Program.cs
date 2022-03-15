using System;

namespace test232
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("아무글자나 입력하세요 끝내려면 '끝을 입력하세요'");
                Console.ReadLine();
                string userinput = Console.ReadLine();
                if (userinput == "끝"){
                    break;
                }
            }
            
        }
    }
}