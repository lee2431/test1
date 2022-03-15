using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumber = { 6, 2, 3, 1, 5, 7 };
            int[] userInput = new int[6];
            

            Console.WriteLine(" 첫번째 숫자를 넣어주세요.");
             userInput[0]= int.Parse(Console.ReadLine());
            Console.WriteLine(" 두번째 숫자를 넣어주세요.");
             userInput[1] = int.Parse(Console.ReadLine());
            Console.WriteLine(" 셋번째 숫자를 넣어주세요.");
             userInput[2] = int.Parse(Console.ReadLine());
            Console.WriteLine(" 넷번째 숫자를 넣어주세요.");
             userInput[3] = int.Parse(Console.ReadLine());
            Console.WriteLine(" 다섯번째 숫자를 넣어주세요.");
             userInput[4] = int.Parse(Console.ReadLine());
            Console.WriteLine(" 여섯번째 숫자를 넣어주세요.");
             userInput[5] = int.Parse(Console.ReadLine());

            if (userInput[0] == passcodeNumber[0] && passcodeNumber[1] == passcodeNumber[1] && userInput[2] == passcodeNumber[2] && passcodeNumber[3] == passcodeNumber[3] && userInput[4] == passcodeNumber[4] && passcodeNumber[5] == passcodeNumber[5])
            { 


                Console.WriteLine("문이 열렸습니다.");
            }
            else { Console.WriteLine("잘못된 비밀번호 입니다."); 
                
            }
            
        }
    }
}