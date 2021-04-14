using System;

namespace SnakeAndLader
{
	class Program
	{
		//Variable declaration
		public static int currentPosition = 0;
		static Boolean playerTurn = true;

		public static int dieRollForPlay(int position, String Player)
		{
			//constants
			const int NO_PLAY = 0;
			const int LADDER = 1;
			const int SNAKE = 2;

			Random random = new Random();
			int diceNumber = random.Next(1, 7);
			int playOption = random.Next(0, 3);
			switch (playOption)
			{

				case NO_PLAY:
					break;
				case LADDER:
					position = position + diceNumber;
					if (position > 100)
					{
						position = position - diceNumber;
					}
					if (position != 100)
					{
						dieRollForPlay(position, Player);

					}
					break;
				case SNAKE:
					position = position - diceNumber;
					if (position < 0)
					{
						position = 0;
					}
					break;
			}
			Console.WriteLine("Position of " + Player + "  " + position);
			return position;
		}


		static void Main(string[] args)
		{
			Console.WriteLine("**********Welcome to Snake And Ladder Game**************");
			int positionOfPlayer_1 = 0;
			int positionOfPlayer_2 = 0;

			while (positionOfPlayer_1 < 100 && positionOfPlayer_2 < 100)
			{
				if (playerTurn)
				{
					positionOfPlayer_1 = dieRollForPlay(positionOfPlayer_1, " Player1 ");
				}
				else
				{
					positionOfPlayer_2 = dieRollForPlay(positionOfPlayer_2, " Player2 ");
				}
				playerTurn = !playerTurn;
			}
			if (positionOfPlayer_1 == 100)
			{
				Console.WriteLine("Player 1 wins!! ");

			}
			else
			{
				Console.WriteLine("Player 2 wins!! ");

			}
		}
	}
}