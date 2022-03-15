using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumber = { 6, 2, 3, 1, 5, 7 };

            int passcodeLength = 6;
            int[] userInput = new int[6];

            while (true)
            {
                
                for (int passcodeIndex = 0;passcodeIndex<6; passcodeIndex ++)
                {
                    Console.Write(passcodeIndex);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());                 
                                   }
                bool isPasswordCorrect = true;
                for (int passcodeIndex = 0;passcodeIndex<passcodeLength;passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumber[passcodeIndex])
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }
           if (isPasswordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break; 
                }



            }
            }

        }
    }
