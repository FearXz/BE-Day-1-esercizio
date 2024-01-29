
namespace Esercizio1  {
    class Program
    {
        static void Main(string[] args) 
        {

            Atleta atleta1 = new Atleta("Pippo", "Franco", 32, "Strongman");
           atleta1.showAtleta();
        }
    }
    class Atleta
    {
        public string nome;
        public string cognome;
        public int eta;
        public string specializzazione;

        public Atleta (string nome, string cognome, int eta, string specializzazione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.specializzazione = specializzazione;
        }
        public void showAtleta ()
        {
            Console.WriteLine($"l'atleta 1 è : {this.nome} {this.cognome}, ed è uno specilista in {this.specializzazione}");
        }

    }

    class Dipendente
    {
        public string nome;
        public string cognome;
        public int eta;
        public string reparto;
       
        public Dipendente (string nome, string cognome ,  int eta, string reparto)
        {
            this.nome = nome;  
            this.cognome = cognome;
            this.eta = eta;
            this.reparto = reparto; 
        }
    }
    class Animale
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
    }
}