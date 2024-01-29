
namespace Esercizio1 {
    class Program
    {
        static void Main(string[] args)
        {

            Atleta atleta1 = new Atleta("Pippo", "Franco", 32, "Strongman");
            atleta1.showAtleta();
            Dipendente dipendente1 = new Dipendente("paperino", "pluto", 22, "logistica");
            dipendente1.showDipendente();
            Animale animale1 = new Animale("Rettile", "Coccodrillo", 8);
            animale1.showAnimale();
            Veicolo veicolo1 = new Veicolo("Lamborhini","xxxAntoxxx");
            veicolo1.showVeicolo();
        }
    }
    class Atleta
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
    class Dipendente
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
        public void showAnimale()
        {
            Console.WriteLine($"l'animale è un : {this.specie} razza: {this.razza}, ed ha {this.eta} anni");
        }


    }
    class Veicolo {
        public string modello;
        public string targa;
        public Veicolo(string modello, string targa)
        {
            this.modello = modello;
            this.targa = targa;
        }
    
    public void showVeicolo()
    {
        Console.WriteLine($"modello auto : {this.modello} targa : {this.targa}");
    }
    }
}

