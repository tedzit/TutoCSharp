using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOuMoins
{
    class Program
    {
        class nombreInconnu
        {
            private int m_nonbreInconnu;

            public nombreInconnu()
            {
                System.Random rand = new System.Random();
                m_nonbreInconnu = rand.Next(100);
            }

            public int Nombre
            {
                get { return m_nonbreInconnu; }
            }
  
        }

        static void Main(string[] args)
        {
            nombreInconnu nombreInconnu=new nombreInconnu() ;
            Console.WriteLine("Bienvennue au super jeu de marde !");
            Console.WriteLine("Entrez un nombre entre 0 et 100");
            string str = Console.ReadLine();
            int guess = 0;
            int.TryParse(str, out guess);
            int nombre = nombreInconnu.Nombre;
            while (guess != nombre)
            {
                if (guess < nombre)
                {
                    Console.WriteLine("C'est plus !");
                    Console.WriteLine("nouvelle tentative!");
                    string str2 = Console.ReadLine();
                    int.TryParse(str2, out guess);
                }
                else if (guess > nombre)
                {
                    Console.WriteLine("C'est moins !");
                    Console.WriteLine("nouvelle tentative!");
                    string str2 = Console.ReadLine();
                    int.TryParse(str2, out guess);
                }
                else
                {
                Console.WriteLine("C'est bon !");
                }
            }
            Console.Read();
        }
    }
}
