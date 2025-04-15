

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to my Casino!");
        Console.WriteLine("Instructions: You will start with $100 and can bet as much as you would like.");
        Console.WriteLine("You will type your answer for rock, paper, scissors, and the computer will generate an answer for itself.");
        Console.WriteLine("If you win, you get money, but if you lose, you lose the money." +
            " After every round you have the option to quit or play again.");
        Console.Title = "Hannahs Casino";
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Hello and welcome to Hannahs Casino! You are playing rock, paper, scissors against the computer. Good luck!");
        Console.WriteLine("Press ENTER once you understand!");
        Console.ReadLine();

        bool done = false;
        Random generator = new Random();
        double bank = 100.00, bet;
        int comp, rock = 1, paper = 2, scissors = 3;
        string answer, choice;

        while (!done)
        {
            Console.WriteLine("Bank amount: " + bank);
            Console.WriteLine("Please enter your bet: ");

            while (!double.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > bank)
            {
                Console.WriteLine("Invalid Bet, please try again: ");
            }

            Console.WriteLine("It's time to make your choice!");
            Console.WriteLine("Choose rock, paper or scissors");
            choice = Console.ReadLine();

            comp = generator.Next(1, 4);

            if (comp == rock && choice.ToLower() == "paper")
            {
                Console.WriteLine("You win! Now you earn your bet money!");
                bank = bank + bet;
                Console.WriteLine("Bank: " + bank.ToString("c"));
            }

            else if (comp == paper && choice.ToLower() == "scissors")
            {
                Console.WriteLine("You win! Now you earn your bet money!");
                bank = bank + bet;
                Console.WriteLine("Bank: " + bank.ToString("c"));
            }

            else if (comp == scissors && choice.ToLower() == "rock")
            {
                Console.WriteLine("You win! Now you earn your bet money!");
                bank = bank + bet;
                Console.WriteLine("Bank: " + bank.ToString("c"));
            }

            else if (comp == paper && choice.ToLower() == "rock")
            {
                Console.WriteLine("You lose! Your bet is lost.");
                bank = bank - bet;
                Console.WriteLine("Bank: " + bank.ToString("c"));
            }

            else if (comp == scissors && choice.ToLower() == "paper")
            {
                Console.WriteLine("You lose! Your bet is lost.");
                bank = bank - bet;
                Console.WriteLine("Bank: " + bank.ToString("c"));
            }

            else if (comp == rock && choice.ToLower() == "scissors")
            {
                Console.WriteLine("You lose! Your bet is lost.");
                bank = bank - bet;
                Console.WriteLine("Bank: " + bank.ToString("c"));
            }

            else if (comp == rock && choice.ToLower() == "rock")
                Console.WriteLine("It is a tie! Try again!");

            else if (comp == scissors && choice.ToLower() == "scissors")
                Console.WriteLine("It is a tie! Try again!");

            else if (comp == paper && choice.ToLower() == "paper")
                Console.WriteLine("It is a tie! Try again!");

            else
                Console.WriteLine("Invalid answer");

            if (bank == 0)
            {
                Console.WriteLine("You ran out of money. Thanks for playing!");
                done = true;
            }

            Console.WriteLine("Do you want to quit?");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Thank you for playing!");
                done = true;
            }
        }
    }
}