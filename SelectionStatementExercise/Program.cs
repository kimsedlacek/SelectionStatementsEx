namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 8;


            Console.WriteLine("Guess my favorite number.");
            int guess = int.Parse(Console.ReadLine());

            if (guess < favNumber)
            {
                Console.WriteLine("to low");
            }
            else if (guess > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine($"Yes, {guess} is my favorite number!");
            }
                                 
        }
    }
}
