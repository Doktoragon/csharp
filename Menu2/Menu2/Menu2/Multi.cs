using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplying
{
    class Multi
    {
        public void Main(string[] args)
        {
            //Iloczyn elementów ciagu n-elementowego.
            {
                int wynik = 1;
                int[] zbior = new int[] { 1,2,5,10 };
                for (int i = 0; i < zbior.Length; i++)
                {
                    wynik *= zbior[i];
                }
                Console.WriteLine($"Wynik wynosi {wynik.ToString()}");
                Console.ReadLine();
            }
        }
    }
}

