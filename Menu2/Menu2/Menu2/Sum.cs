using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaOfN
{
    class sum

    {
        //Suma elementów ciągu n-elementowego
        public void Main(string[] args)
        {
            int wynik = 0; //Wynik wynosi 0
            int[] zbior = new int[] { 4, 8, 15, 16, 23, 42 };  //Zbiór liczb ciągu, + pozycji, zaczyna się od i[0]=4
            for (int i = 0; i < zbior.Length; i++) //Rozpoczęcie pętli, dla i o indexie 0, które jest mniejsze od ilościu elementów zbioru, i zwiększa się o:
            {
                wynik += zbior[i];   // Wynik  + 4 + 8 + 15 + 16 
            }
            Console.WriteLine($"Wynik sumy elementów ciągu wynosi: {wynik.ToString()}");
            Console.ReadKey();
        }
    }
}
