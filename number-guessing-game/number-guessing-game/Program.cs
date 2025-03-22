namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rand_number = random.Next(1, 101);

            bool is_guessing_num;
            int tries = 1;

            Console.Write("Guess a number from 1-100: ");
            int usr_guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (usr_guess == rand_number)
            {
                is_guessing_num = false;
            } else
            {
                is_guessing_num = true;
                while (is_guessing_num)
                {
                    if (usr_guess > rand_number) 
                    {
                        Console.Write(usr_guess + " is too high!\nTry again: ");
                        usr_guess = Convert.ToInt32(Console.ReadLine());
                        tries++;
                        Console.WriteLine();
                    } else if (usr_guess < rand_number)
                    {
                        Console.Write(usr_guess + " is too low!\nTry again: ");
                        usr_guess = Convert.ToInt32(Console.ReadLine());
                        tries++;
                        Console.WriteLine();
                    } else if (usr_guess == rand_number)
                    {
                        Console.WriteLine("Bingo! You guessed it correctly in " + tries + " tries.");
                        is_guessing_num = false;
                    }
                }
            }
        }
    }
}
