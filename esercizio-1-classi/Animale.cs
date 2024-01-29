using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_1_classi_Animale
{
    internal class Animale
    {
        public string specie;
        public string razza;
        public int eta;
        public Animale(string specie, string razza, int eta)
        {
            this.specie = specie;
            this.razza = razza;
            this.eta = eta;
        }
        public void showAnimale()
        {
            Console.WriteLine($"l'animale è un : {this.specie} razza: {this.razza}, ed ha {this.eta} anni");
        }
    }
}
