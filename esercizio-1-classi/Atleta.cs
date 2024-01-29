using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_1_classe_Atleta
{
    internal class Atleta
    {
        public string nome;
        public string cognome;
        public int eta;
        public string specializzazione;

        public Atleta(string nome, string cognome, int eta, string specializzazione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.specializzazione = specializzazione;
        }
        public void showAtleta()
        {
            Console.WriteLine($"l'atleta 1 è : {this.nome} {this.cognome}, ed è uno specilista in {this.specializzazione}");
        }
    }
}
