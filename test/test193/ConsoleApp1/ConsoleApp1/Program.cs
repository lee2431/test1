using System;

namespace test193
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subject = { "국어", "수학", "영어" };
            int[] scores =new int [3];

            Console.WriteLine(subject[0]);
            scores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine(subject[1]);
            scores[1] = int.Parse(Console.ReadLine());
            Console.WriteLine(scores[1]);
            Console.WriteLine(subject[2]);
            Console.WriteLine(scores[2]);

        }
    }
}