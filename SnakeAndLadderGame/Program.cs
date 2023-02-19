namespace SnakeAndLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0, rollDice;
            int playerOne;
            playerOne = position;
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("....Snake And Ladder....");
            Console.WriteLine("position of the playerone is =" + playerOne);
            Console.WriteLine("Rolled dice number is:" + rollDice);
            Console.ReadLine();

        }
    }
}