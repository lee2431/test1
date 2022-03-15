using System;

namespace test232
{
    class Program
    {
        static void Main(string[] args)
        { int[] number = new int[5];
            int over = 0;
            while (over < 5)
            {
                Console.Write(over);
                Console.WriteLine("번째 성적을 입력하세요.");
                number [over] = int.Parse(Console.ReadLine());
                over++;
            }
            Console.Write("총점은: ");
            Console.WriteLine(number[0] + number[1] + number[2] + number[3] + number[4]  )     ; }
    }
} 