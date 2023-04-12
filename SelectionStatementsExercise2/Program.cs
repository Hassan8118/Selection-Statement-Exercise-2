namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();
            switch (subject)
            {
                case "Science":
                    Console.WriteLine("Science can be interesting at times");
                    break;
                case "Social Studies":
                    Console.WriteLine("Social Studies is so boring");
                    break;
                case "English":
                    Console.WriteLine("English is too much reading");
                    break;
                default: Console.WriteLine("I dont mind that subject");
                    break;
            }
        }
    }
}