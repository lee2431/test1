using System;

namespace test225
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                number = number + 1;
                if (number ==3)
                {
                    continue;
                }
                Console.Write(number);
                Console.WriteLine("번째 출력");
               if (number == 20)
                {
                    break;
                }
            }
        }
    }
}