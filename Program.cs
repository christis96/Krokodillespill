namespace Krokodillespill;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        while (true)
        {
            generator g = new generator();
            comparer c = new comparer();
            int number1 = g.GetRandomNumber();
            int number2 = g.GetRandomNumber();
        
            Console.WriteLine($"{number1}_{number2}");
            string input = Console.ReadKey().KeyChar.ToString();
            
            if (input != "<" && input != ">" && input != "=")
            {
                Console.WriteLine("\nUgyldig tegn. Avslutter spillet.");
                break;
            }
            
            string riktig = c.GetComparisonSymbol(number1, number2);
            if (input == riktig)
            {
                points++;
            }
            else
            {
                points--;
            }

            Console.WriteLine($"\nPoeng: {points}");
        }
        
        
        

    }
    
    
}