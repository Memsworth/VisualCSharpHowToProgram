namespace VisualCSharpHowToProgram.ChapterEight;

public class EratosthenesSieve
{
    public static void RunProgram()
    {
        var primes = new bool[1000];
        Array.Fill(primes, true);


        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i] == false)
            {
                continue;
            }

            for (int j = i*i; j < primes.Length; j+=i)
            {
                if (primes[j] == false)
                {
                    continue;
                } 
                primes[j] = false;

            }
        }

        Console.WriteLine("Here are the prime numbers: ");
        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i])
            {
                Console.WriteLine($"{i} is a prime");
            }
        }
        
    }
}