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
            Console.WriteLine("Entrez un nombre entre 0 et 100");

            nombreInconnu nombreInconnu = new nombreInconnu();
            int guess = 0;
            int nombre = nombreInconnu.Nombre;
            int essai = nombreInconnu.Essai;

            do
            {

                string str = Console.ReadLine();
                int.TryParse(str, out guess);
                nombreInconnu.plusOuMoins(guess);
                essai = nombreInconnu.Essai;

            } while (guess != nombre && essai >= 0);

            Console.Read();
        }
    }
}
