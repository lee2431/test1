using System;

namespace hardtest
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine(" 주머니에는 동전이 10개 들어 있습니다.");
            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            int lee = int.Parse(Console.ReadLine());
            int coin = 10;
            
            Console.WriteLine("덕환이는 몇 개의 동전을 꺼냈나요?");
            int output = int.Parse(Console.ReadLine());
            
            Console.WriteLine("은환이는 몇 개의 동전을 꺼냈나요?");
            int out2 = int.Parse(Console.ReadLine());
            Console.Write("남은 동전의 개수는 ");
            Console.Write(lee + coin - output - out2);
            Console.WriteLine(" 개 입니다");
        }
    }
}