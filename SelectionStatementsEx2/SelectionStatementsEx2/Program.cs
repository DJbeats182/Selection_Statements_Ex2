namespace SelectionStatementsEx2
{
   
    
        internal class Program
        {
            static void Main(string[] args)
            {
                //--------------------Switch-Case-----------------------

                Console.WriteLine("What is your favorite subject?");
                string subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "math":
                        Console.WriteLine("I hate Math!");
                        break;
                    case "science":
                        Console.WriteLine("I love Science!");
                        break;
                    case "pe":
                        Console.WriteLine("P.E. is great exercise!");
                        break;
                    case "history":
                        Console.WriteLine("History is very interesting!");
                        break;
                    case "english":
                        Console.WriteLine("English is really boring.");
                        break;
                    default:
                        Console.WriteLine("I don't know that subject.");
                        break;
                }
            }
        }
    }
