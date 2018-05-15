using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNums


{
    class average
    {
        public static void Execute(int[] tab)
        {
            int iloscLiczb = 0;  //Zmienne, wyzerowane na początku
            double suma = 0;

            Console.Write("Ile liczb chcesz zawrzeć w średniej: "); //Otrzymuję ile liczb będzie branych pod uwagę, int32.Parse konwertuje je na int.(liczbę całkowitą)
            iloscLiczb = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < iloscLiczb; i++) //pętla obliczająca
            {
                Console.Write("Podaj liczbę: "); //Liczby wpisywane przez użytkownika, suma = suma + liczba
                suma += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Średnia arytmetyczna z podanych liczb wynosi: " + suma / iloscLiczb);
            Console.ReadKey();
        }
    }
}
