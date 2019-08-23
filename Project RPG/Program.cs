using System;
using Characters;
using Enemies;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Character char1 = new Character();
            String UserInput;
            char1.PrintCharacter();
            
            Console.WriteLine("Type y to battle.");
            UserInput = Console.ReadLine();

            while (UserInput == "y") {
                Enemy Enemy = new Enemy();

            }
        }
    }
}
