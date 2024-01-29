using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_1_classi_Veicolo
{
    internal class Veicolo
    {
        public string modello;
        public string targa;

        public Veicolo(string modello , string targa)
        {
            this.modello = modello;
            this.targa = targa;
                
        }

        public void showVeicolo()
        {
            Console.WriteLine($"modello auto : {this.modello} , targa:  {this.targa}");
        }
    }
}
