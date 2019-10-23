using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Primes
{
    class Program
    {

     
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Prime Number Generator!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1) Select your own numbers");
            Console.WriteLine("2) Find primes from 1 to 1.000.000");
            Console.WriteLine("3) Exit the program");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    EnterNumbers();
                    return true;
                case "2":
                    PresetNumbers();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        public static void PresetNumbers()
        {
            long first = 1;
            long last = 1000000;

            PrimeGenerator primegenerator = new PrimeGenerator();
            List<long> primesSequential = new List<long>();
            List<long> primesParallel = new List<long>();

            Console.WriteLine("Sequential calculation is running...");
            Console.WriteLine("To stop the operation, press Esc");
            MessureTime(() =>
            {
                primesSequential = primegenerator.GetPrimesSequential(first, last);
            });

            PrintInfo(primesSequential);

            Console.WriteLine("Parallel calculation is running...");
            Console.WriteLine("To stop the operation, press Esc");
            MessureTime(() =>
            {
                primesParallel = primegenerator.GetPrimesParallel(first, last);
            });

            PrintInfo(primesParallel);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void EnterNumbers()
        {
            long first = 1;
            long last = 0;

            Console.Write("    Enter first number: ");
            first = long.Parse(Console.ReadLine());
            Console.Write("    Enter last number: ");
            last = long.Parse(Console.ReadLine());
            Console.WriteLine();

            PrimeGenerator primegenerator = new PrimeGenerator();
            List<long> primesSequantial = new List<long>();
            List<long> primesParallel = new List<long>();

            Console.WriteLine("Sequential calculation is running...");
            Console.WriteLine("To stop the operation, press Esc");
            MessureTime(() =>
            {
                primesSequantial = primegenerator.GetPrimesSequential(first, last);
            });

            PrintInfo(primesSequantial);

            Console.WriteLine("Parallel calculation is running...");
            Console.WriteLine("To stop the operation, press Esc");
            MessureTime(() =>
            {
                primesParallel = primegenerator.GetPrimesParallel(first, last);
            });

            PrintInfo(primesParallel);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void MessureTime(Action p)
        {
            Stopwatch sw = Stopwatch.StartNew();
            p.Invoke();
            sw.Stop();
            Console.WriteLine(" ------>The total time = {0:F5} sec.", sw.ElapsedMilliseconds / 1000d);
        }
        public static void PrintInfo(List<long> primes)
        {
            Console.WriteLine($"        Total prime numbers found: {primes.Count}");
            Console.WriteLine($"        The smallest prime number found: {primes[0]}");
            Console.WriteLine($"        The largest prime number found: {primes[primes.Count - 1]}");
            Console.WriteLine();
        }

    }
}
