using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zgadnij_jaka_to_liczba2
{
    class Program
    {
        static void Menu()
        {
            Console.Title = ("Zgadnij Liczbe");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1-Poziomy");
                Console.WriteLine("2-Wyjscie");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); JeszczeNieMa(); break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0); break;

                    default: break;

                }

            }

        }
        static void JeszczeNieMa()
        {
            Console.WriteLine(" Narazie tyle");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            void Menu()
            {
                Console.Title = ("Zgadnij Liczbe");

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("MENU");
                    Console.WriteLine("1-Poziomy");
                    Console.WriteLine("2-Wyjscie");

                    ConsoleKeyInfo klawisz = Console.ReadKey();
                    switch (klawisz.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear(); JeszczeNieMa(); break;

                        case ConsoleKey.Escape:
                        case ConsoleKey.D3:
                            Environment.Exit(0); break;

                        default: break;

                    }

                }
                void JeszczeNieMa()
                {
                    Console.WriteLine(" Narazie tyle");
                    Console.ReadKey();

                }


                int min = 0;
                int max = 100;
                Random liczba1 = new Random();
                int a = liczba1.Next(1, max);
                int liczba;

                Console.WriteLine($"Wylosowałam liczbę od {min} do {max}. Zgadnij jaka to liczba");
                do
                {
                    liczba = int.Parse(Console.ReadLine());



                    if (liczba < a)
                    {
                        Console.WriteLine("Za mało. Sprobuj jeszcze raz");
                    }
                    if (liczba > a)
                    {
                        Console.WriteLine("Za dużo. Sprobuj jeszcze raz");
                    }
                } while (liczba != a);

                Console.WriteLine("Brawo! zgadłeś liczbę");

                Console.Read();

            }

        }

    }
}


    
    
