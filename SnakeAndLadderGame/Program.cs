namespace SnakeAndLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Snake = 0;
            const int Ladder = 1;
            const int NoGame = 2;
            int position = 0;
            int diceCount = 0;
            Random random = new Random();

            while (position < 100)
            {
                int diceRoll = random.Next(1, 7);
                Console.WriteLine("Rolled Dice number is:" + diceRoll);
                diceCount++;
                int choice = random.Next(0, 3);

                switch (choice)
                {
                    case Snake:
                        position -= diceRoll;
                        Console.WriteLine("Its a snake");
                        if (position < 0)
                        {
                            position = 0;
                            Console.WriteLine("Player 1 position :" + position);
                        }
                        else
                        {
                            Console.WriteLine("Player 1 position : " + position);
                        }
                        break;
                    case Ladder:
                        position += diceRoll;
                        Console.WriteLine("Its a ladder");
                        if (position == 100)
                        {
                            Console.WriteLine("Player 1 wins");
                        }
                        else if (position > 100)
                        {
                            position -= diceRoll;
                            Console.WriteLine("position is above 100; doesn't Count");
                        }
                        else
                        {
                            Console.WriteLine("Player 1 position :" + position);
                        }
                        break;
                    case NoGame:
                        Console.WriteLine("Its a NoGame");
                        Console.WriteLine("Player 1 position : " + position);
                        break;

                }
            }
            Console.WriteLine("Dice Count to win the Game: " + diceCount);
            Console.ReadLine();
        }
    }
}
