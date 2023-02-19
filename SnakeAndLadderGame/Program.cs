namespace SnakeAndLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Snake = 0;
            const int Ladder = 1;
            const int NoGame = 2;
            const int player1 = 0;
            const int player2 = 1;
            int playerposition1 = 0;
            int playerposition2 = 0;
            int diceCount = 0;
            int player = player1;
            Random random = new Random();

            while (playerposition1 < 100 && playerposition1 < 100)
            {
                int diceRoll, choice;
                diceRoll = random.Next(1, 7);
                Console.WriteLine("Rolled Dice number is:" + diceRoll);
                choice = random.Next(0, 3);
                if (player == player1)
                {
                    switch (choice)
                    {
                        case Snake:
                            playerposition1 -= diceRoll;
                            Console.WriteLine("Its a snake");
                            if (playerposition1 < 0)
                            {
                                playerposition1 = 0;
                                Console.WriteLine("Restart Game");
                                Console.WriteLine("Player 1 position :" + playerposition1);
                            }
                            else
                            {
                                Console.WriteLine("Player 1 position : " + playerposition1);
                            }
                            player = player2;
                            break;
                        case Ladder:
                            playerposition1 += diceRoll;
                            Console.WriteLine("Its a ladder");
                            if (playerposition1 == 100)
                            {
                                Console.WriteLine("PLAYER-1  wins");
                            }
                            else if (playerposition1 > 100)
                            {
                                playerposition1 -= diceRoll;
                                Console.WriteLine("player 1 position is above 100; doesn't Count" + player);
                            }
                            else
                            {
                                Console.WriteLine("Player 1 position :" + playerposition1);
                            }
                            player = player1;
                            break;
                        case NoGame:
                            Console.WriteLine("Its a NoGame");
                            Console.WriteLine("Player 1 position : " + playerposition1);
                            player = player2;
                            break;
                    }
                }



                else
                {
                    switch (choice)
                    {
                        case Snake:
                            playerposition2 -= diceRoll;
                            Console.WriteLine("Its a snake");
                            if (playerposition2 < 0)
                            {
                                playerposition2 = 0;
                                Console.WriteLine("Restart Game");
                                Console.WriteLine("Player 2 position :" + playerposition2);
                            }
                            else
                            {
                                Console.WriteLine("Player 2 position : " + playerposition2);
                            }
                            player = player1;
                            break;
                        case Ladder:
                            playerposition2 += diceRoll;
                            Console.WriteLine("Its a ladder");
                            if (playerposition2 == 100)
                            {
                                Console.WriteLine("PLAYER-2  wins");
                            }
                            else if (playerposition2 > 100)
                            {
                                playerposition2 -= diceRoll;
                                Console.WriteLine("player 1 position is above 100; doesn't Count" + player);
                            }
                            else
                            {
                                Console.WriteLine("Player 2 position :" + playerposition2);
                            }
                            player = player2;
                            break;
                        case NoGame:
                            Console.WriteLine("Its a NoGame");
                            Console.WriteLine("Player 2 position : " + playerposition2);
                            player = player1;
                            break;

                    }
                }
                diceCount++;
            }
            Console.WriteLine("Dice Count to win the Game: " + diceCount);
            Console.ReadLine();
        }
    }
}
