using System;
using Characters;
using Enemies;
using Environments;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Char1 = new Character();
            String UserInput;
            Char1.PrintCharacter();
            
            Console.WriteLine("Type y to battle.");
            UserInput = Console.ReadLine();

            while (UserInput == "y") {
                Enemy Enemy1 = new Enemy();
                Combat.Battle(Char1, Enemy1);
            }
        }
    }
}
