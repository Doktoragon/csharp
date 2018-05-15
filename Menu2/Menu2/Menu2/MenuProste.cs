using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{

    static class MenuProste
    {
        public static void StartMenuProste()
        {
            Console.Title = "Moje menu";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>> Witaj! Wciśnij klawisz, aby wybrać algorytm! <<<");
                Console.WriteLine("1- Wybierz zdefiniowany wcześniej ciąg liczb.");
                Console.WriteLine("2- Zdefiniuj własny ciąg liczb.");
                Console.WriteLine("3- Wybierz losowy ciąg liczb.");
                Console.WriteLine("4- Suma elementów ciagu n-elementowego.");
                Console.WriteLine("5- Iloczyn elementów ciagu n-elementowego.");
                Console.WriteLine("6- Srednia arytmetyczna elementów ciagu n-elementowego.");
                Console.WriteLine("7- Wypisanie elementów ciagu Fibonacciego");
                Console.WriteLine("8- Ile jest elementów dodatnich, ujemnych lub równych zero w danym ciagu n-elementowym. ");
                Console.WriteLine("9- Ile razy dany element podany na wejsciu wystepuje w danym ciagu n-elementowym.");
                Console.WriteLine("0- Koniec");

                int[] tab = null;

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        tab = PreDefinedArray();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        tab = UserDefinedArray();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        tab = RandomArray();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        opcjaWBudowie();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        opcjaWBudowie();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        AverageNums();
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        opcjaWBudowie();
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        opcjaWBudowie();
                        break;
                    case ConsoleKey.D9:
                        Console.Clear();
                        opcjaWBudowie();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D0:
                        Environment.Exit(0); break;

                    default: break;
                }
            }
        }

        private static void AverageNums()
        {
            throw new NotImplementedException();
        }

        private static int[] RandomArray()
        {
            Random r = new Random();
            int size = r.Next(1, 100); ///rozmiar tablicy (od 1 do 100)
            int[] array = new int[size]; /// stwórz tablicę
            for (int i=0; i<size; i++) ///wypełnienie tablicy
            {
                array[i] = r.Next(1, 100);
            }
            return array;
        }

        private static int[] UserDefinedArray()
        {
            throw new NotImplementedException();
        }

        private static int[] PreDefinedArray()
        {
            int[] Array = new int[6] {4, 8, 15, 16, 23, 42};
            return Array;
        
        }

        static void opcjaWBudowie()
        {
            Console.Write("Opcja w budowie!");
            Console.ReadKey();
        }
    }
}

