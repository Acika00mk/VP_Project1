using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project1
{
    public class Uplata
    {
        private string Name;
        private int Konj,Iznos;
        private decimal  Koeficient, Vkupno;
        public Uplata(string name, int konj, decimal koef,int iznos)
        {
            Name = name;
            Konj = konj;
            Koeficient = koef;
            Iznos = iznos;
            Vkupno = Iznos*Koeficient;

        }
        public override string ToString()
        {
            return string.Format(Name  + " " + Konj   + " : " + Koeficient + " x " +Iznos +"=" + Vkupno);
        }
    }
}
