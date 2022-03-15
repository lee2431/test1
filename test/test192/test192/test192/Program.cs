using System;

namespace test192
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 학생은 몇명 입니까");
            int studentName1 = int.Parse(Console.ReadLine());
            double [] studentName = new double [studentName1];

            Console.WriteLine(" 첫 번째 무게: ");
            studentName[0] = double.Parse(Console.ReadLine());
            Console.WriteLine(" 두 번째 무게: ");
            studentName[1] = double.Parse(Console.ReadLine());
            Console.WriteLine(" 세 번째 무게: ");
            studentName[2] = double.Parse(Console.ReadLine());

            Console.WriteLine(studentName[0]);
            Console.WriteLine(studentName[1]);
            Console.WriteLine(studentName[2]);
        }
    }
}
            


            