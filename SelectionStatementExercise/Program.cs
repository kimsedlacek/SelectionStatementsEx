namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 56;

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low, try again.");
            }
                
            else if (userInput > favNumber)
            {
                Console.WriteLine($" {userInput} is too high, try again.");
            }
               
            else
            {
                Console.WriteLine($"Yes! 56 is my favorite number!");
            }
                
       


         
        }
    }
}
