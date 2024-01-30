using esercizio_1_classe_Atleta;
using esercizio_1_classi_Animale;
using esercizio_1_classi_Dipendente;
using esercizio_1_classi_Veicolo;

namespace Esercizio1
{
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

            Veicolo veicolo1 = new Veicolo("Lamborghini", "xxxAntoxxx");
            veicolo1.showVeicolo();

        }
    }
}

