using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvennue au super jeu de marde !");
            Console.WriteLine("---------------- Menu Principal ---------------");
            Console.WriteLine("--- Taper 1 pour jouer au jeu Plus ou Moins ---");
            Console.WriteLine("--- Taper 2 pour quitter ---");

            int action = 0;
            string actionTxt = Console.ReadLine();
            int.TryParse(actionTxt, out action);

            switch (action)
            {
                case 1:
                {
                    nombreInconnu nombreInconnu = new nombreInconnu();

                    Console.WriteLine("Choisissez une difficulté");
                    Console.WriteLine("Tapez 1 : Facile vous avez 8 essais ");
                    Console.WriteLine("Tapez 2 : Moyen vous avez 6 essais ");
                    Console.WriteLine("Tapez 3 : Difficile vous avez 4 essais ");
                    int difficulte = 0;
                    string difficulteTxt = Console.ReadLine();
                    int.TryParse(difficulteTxt, out difficulte);
                    switch (difficulte)
                    {
                        case 1:
                            {
                                    nombreInconnu.Essai=7;
                            }
                            break;
                        case 2:
                            {
                                    nombreInconnu.Essai=5;
                            }
                            break;
                        case 3:
                            {
                                    nombreInconnu.Essai=3;
                            }
                            break;
                    }

                    Console.WriteLine("Entrez un nombre entre 0 et 100");
                    bool test = false;
                    int guess = 0;
                    int essai = nombreInconnu.Essai;

                    do
                    {

                        string str = Console.ReadLine();
                        int.TryParse(str, out guess);
                        nombreInconnu.plusOuMoins(guess);
                        test = nombreInconnu.verif(guess);
                        essai = nombreInconnu.Essai;

                    } while (test!=true && essai >= 0);
                }
                break;
                case 2:
                {
                    Console.WriteLine("Aurevoir a bientot...");
                    Environment.Exit(0);
                }
                break;

                default:
                {
                    Console.WriteLine("Commande inconnue Arret system");
                }
                break;    
            }   

            Console.Read();
        }
    }
}