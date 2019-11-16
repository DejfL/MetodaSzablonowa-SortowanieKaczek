using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowaSortowanieKaczek.Model
{
    class Kaczka : IComparable
    {
        string nazwa;
        int waga;

        public Kaczka(string nazwa, int waga)
        {
            this.nazwa = nazwa;
            this.waga = waga;
        }

        public override String ToString()
        {
            return nazwa + " wazy " + waga;
        }
        public int CompareTo(object obj)
        {
            Kaczka kaczka = (Kaczka)obj;

            if (this.waga < kaczka.waga)
                return -1;
            else if (this.waga == kaczka.waga)
                return 0;
            else
                return 1;
        }
    }
}
