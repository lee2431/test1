using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int passcodeLength = 6;
            int[] passcodeNumber = new int[passcodeLength];

            Console.WriteLine("비밀번호");
            for(int  i =0; i<passcodeLength; i++)
            {
                passcodeNumber[i] = random.Next(0, 10);
                Console.Write(passcodeNumber[i]);
                Console.Write("");
            }
            Console.WriteLine();

            int[] userInput = new int[passcodeLength];

            while (true)
            {
                
                for (int userInputNumber = 0; userInputNumber < passcodeLength; userInputNumber++)
                {
                    Console.Write(userInputNumber);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[userInputNumber] = int.Parse(Console.ReadLine());
                }
                bool correctpassword = true;
                for (int userInputNumber = 0; userInputNumber < passcodeLength; userInputNumber++)
                {
                    if (userInput[userInputNumber] != passcodeNumber[userInputNumber])
                    {
                        correctpassword = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }
                if (correctpassword)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }



            }
        }

    }
}
