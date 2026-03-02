using System;

namespace TemaAcasa
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("=== Calculator Salariu ===");

                Console.Write("Introduceti numarul de ore lucrate (0 pentru iesire): ");
                if (!int.TryParse(Console.ReadLine(), out int ore))
                {
                    Console.WriteLine("Numar invalid!\n");
                    continue;
                }

                if (ore == 0)
                    break;

                Console.Write("Introduceti tariful pe ora: ");
                if (!double.TryParse(Console.ReadLine(), out double tarif))
                {
                    Console.WriteLine("Tarif invalid!\n");
                    continue;
                }

                double salariu = ore * tarif;

                Console.WriteLine($"\nSalariul este: {salariu} lei");

                if (salariu > 3000)
                {
                    Console.WriteLine("Salariu mare");
                }
                else if (salariu >= 2000)
                {
                    Console.WriteLine("Salariu mediu..\r\nAti lucrat prea putine ore pentru a avea un salariu mare!");
                }
                else
                {
                    Console.WriteLine("Salariu mic.\r\nAti lucrat prea putine ore pentru a avea un salariu mare!");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Program inchis.");
            Console.ReadKey();
        }
    }
}
