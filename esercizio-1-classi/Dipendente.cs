using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_1_classi_Dipendente
{
    internal class Dipendente
    {
        public string nome;
        public string cognome;
        public int eta;
        public string reparto;

        public Dipendente(string nome, string cognome, int eta, string reparto)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.reparto = reparto;
        }
        public void showDipendente()
        {
            Console.WriteLine($"il dipendente 1 è : {this.nome} {this.cognome}, e lavora nel reparto {this.reparto}");
        }
    }
}
