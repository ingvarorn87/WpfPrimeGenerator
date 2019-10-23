using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primes
{
    class PrimeGenerator
    {
        public List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primes = new List<long>();
            List<long> result = new List<long>();
            bool quit = false;
            if (last >= 2) primes.Add(2);
            if (2 <= last && 2 >= first) result.Add(2);
            long currentNumber = 3;

            while (!quit)
            {
                if (Console.KeyAvailable)
                    quit = Console.ReadKey().Key == ConsoleKey.Escape;

                if (CheckIfPrimeSequential(currentNumber, primes))
                {
                    primes.Add(currentNumber);
                    if (currentNumber <= last && currentNumber >= first) result.Add(currentNumber);
                }
                if (currentNumber < last)
                    currentNumber += 2;
                else
                    break;
            }

            return result;
        }


        public List<long> GetPrimesParallel(long first, long last)
        {
            List<long> primes = new List<long>();
            List<long> result = new List<long>();

            bool quit = false;
            if (last >= 2) primes.Add(2);
            if (2 <= last && 2 >= first) result.Add(2);
            long currentNumber = 3;

            while (!quit)
            {
                if (Console.KeyAvailable)
                    quit = Console.ReadKey().Key == ConsoleKey.Escape;

                if (CheckIfPrimeParallel(currentNumber, primes))
                {
                    primes.Add(currentNumber);
                    if (currentNumber <= last && currentNumber >= first) result.Add(currentNumber);
                }

                if (currentNumber < last)
                    currentNumber += 2;
                else
                    break;
            }

            return result;
        }
        private bool CheckIfPrimeParallel(long num, List<long> primes)
        {
            if ((num % 2) == 0) return false;

            bool isPrimeNumber = true;

            Parallel.ForEach(primes.TakeWhile(prime => prime * prime <= num),
                (prime, loopState) =>
                {
                    if ((num % prime) == 0)
                    {
                        isPrimeNumber = false;
                        loopState.Stop();
                    }
                });

            return isPrimeNumber;
        }
        private bool CheckIfPrimeSequential(long num, List<long> primes)
        {
            if ((num % 2) == 0) return false;

            foreach (long prime in primes.TakeWhile(prime => prime * prime <= num))
            {
                if ((num % prime) == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
