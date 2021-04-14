using System;

namespace SnakeAndLader
{
	class Program
	{
		//Variable declaration
		public static int currentPosition = 0;
		static Boolean playerTurn = true;

		/// <summary>
		/// dieRollForPlay() is used to get random die position for play and also dice number.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="Player"></param>
		/// <returns></returns>
		public static int dieRollForPlay(int position, String Player)
		{
			//constants
			const int NO_PLAY = 0;
			const int LADDER = 1;
			const int SNAKE = 2;
			//
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

		/// <summary>
		/// Driver method ----->execution starts from here
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine("**********Welcome to Snake And Ladder Game**************");
			int positionOfPlayer_1 = 0;
			int positionOfPlayer_2 = 0;
			int diceRollTotal = 0;

			//While player 1 and player 2 position is less than 100 will loop will execute.
			while (positionOfPlayer_1 < 100 && positionOfPlayer_2 < 100)
			{
				diceRollTotal++;
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

			//If player 1 position is exact win osition then Player 1 win.
			if (positionOfPlayer_1 == 100)
			{
				Console.WriteLine("Player 1 wins!! ");
				Console.WriteLine("Total numbers of time dice rolled for Player 1 is : " + diceRollTotal);

			}
			//Otherwise Player 2 win
			else
			{
				Console.WriteLine("Player 2 wins!! ");
				Console.WriteLine("Total numbers of time dice rolled for Player 2 is : " + diceRollTotal);

			}
		}
	}
}