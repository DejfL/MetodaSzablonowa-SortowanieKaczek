using MetodaSzablonowaSortowanieKaczek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowaSortowanieKaczek
{
    class Program
    {
        static void Main(string[] args)
        {
            Kaczka[] kaczki =
            {
                new Kaczka("Kaczor dafy", 32),
                new Kaczka("Kaczor dewy", 3),
                new Kaczka("Kaczor donald", 5),
                new Kaczka("Kaczor howart", 1)
            };

            Console.WriteLine("Przed sortowaniem");
            WyswietlKaczki(kaczki);

            Array.Sort(kaczki);
            Console.WriteLine("Po sortowaniu");
            WyswietlKaczki(kaczki);
            Console.ReadKey();
        }

        static void WyswietlKaczki(Kaczka[] kaczki)
        {
            for (int i = 0; i < kaczki.Length; i++)
            {
                Console.WriteLine(kaczki[i]);
            }
        }
    }
}
