using System;

namespace DemoClasseEnSalle
{
    public class Test {
        private int idClasse;
        private string nomClasse;

        public Test()
        {
            idClasse = 0;
            nomClasse = "Pas défini";
        }

        public int getIdClasse() {
            return idClasse;
        }
        public void setIdClasse(int nouvelleValeur) {
            if (nouvelleValeur > 100 || nouvelleValeur < 0) {
                Console.WriteLine("Valeur dans une plage invalide.");
            }
            else { 
                idClasse = nouvelleValeur;
            }
        }
        public string getNomClasse() {
            return nomClasse;
        }
        public void setNomClasse(string nouvelleValeur) {
            nomClasse = nouvelleValeur;
        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            Test monPremierTest = new Test();
            monPremierTest.setIdClasse(1);
            monPremierTest.setNomClasse("Hello World");

            Console.WriteLine(monPremierTest.getIdClasse());
            Console.WriteLine(monPremierTest.getNomClasse());

            Test monDeuxiemeTest = new Test();
            monDeuxiemeTest.setIdClasse(2);
            monDeuxiemeTest.setNomClasse("Bonjour le monde");

            Console.WriteLine(monDeuxiemeTest.getIdClasse());
            Console.WriteLine(monDeuxiemeTest.getNomClasse());

        }
    }
}
