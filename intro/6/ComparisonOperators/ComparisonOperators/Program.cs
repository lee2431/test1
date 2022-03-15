using System;

namespace ComparionOperatorㄴ
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write(" 10>10 은 ");
            Console.WriteLine(10 > 10); //거짓

            Console.Write(" 10>=10 은 ");
            Console.WriteLine(10 >= 10); //참

            Console.Write(" 5<10 은 ");
            Console.WriteLine(5< 10); //거짓

            Console.Write(" 5<=10 은 ");
            Console.WriteLine(5 <= 10);

            Console.Write(" 5==10 은 ");
            Console.WriteLine(5 == 10);

            Console.Write(" 5 !=10 은 ");
            Console.WriteLine(5 != 10);


        }
    }
}