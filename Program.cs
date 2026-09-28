namespace GuessRandomNumber;

class Program
{
    static void Main(string[] args)
    {
        // Instruktioner:
        Console.WriteLine("Welcome to the random number guessing game!");
        // • Generera ett slumptal mellan 1 och 100.
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;
        //Om du vill kan du hålla reda på hur många försök det tar för användaren
        //att gissa rätt antal.
        int attempts = 0;

        while (guess != secretNumber)
        {
            // • Be användaren att gissa numret.
            Console.WriteLine("Please enter a guess between 1-100:");
            guess = int.Parse(Console.ReadLine()!);
            //Attempts räknas upp för varje fel gissning
            attempts++;

            // • Använd en while-loop för att fortsätta be om gissningar tills användaren
            // gissar rätt nummer.
            // • Ge feedback för varje gissning:
            // • Om gissningen är lägre än det genererade antalet, skriv ut "För lågt!"
            // • Om gissningen är högre än det genererade numret, skriv ut "För högt!"
            // • Om gissningen är korrekt, skriv ut "Grattis! Du gissade siffran!"
            if (guess < secretNumber)
            {
                Console.WriteLine("Too low, please try again!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high, please try again!");
            }
            else
            {
                Console.WriteLine($"Nice, you guessed the number in {attempts} attempts!");
            }
        }
    }
}
