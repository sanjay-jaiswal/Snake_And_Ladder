using System;

namespace SnakeAndLader
{
    class Program
    {
        //Variable declaration
        public static int currentPosition = 0;
        //constants declaration
        const int START_POISTION = 0;
        const int END_POSTION = 100;

        public static int diceRoll()
        {
            Random random = new Random();
            int num = random.Next(1, 7);
            return num;
        }
        static void Main(string[] args)
        {
            currentPosition += diceRoll();
            Console.WriteLine("**********Welcome to Snake And Ladder Game**************");
            Console.WriteLine("start postion is: " + START_POISTION);
            Console.WriteLine("end postion is: " + END_POSTION);

        }
    }
}
