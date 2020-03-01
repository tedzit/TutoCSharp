using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOuMoins
{
    public class nombreInconnu
    {
        public nombreInconnu()
        {
            System.Random rand = new System.Random();
            m_nombreInconnu = rand.Next(100);
            m_nombreEssai = 5;
        }

        public bool verif (int guess)
        {
            bool check = true;
            if (guess == m_nombreInconnu)
            {
                return check;
            }
            else
            {
                check = false;
                return check;
            }
        }

        public int Essai
        {
            get { return m_nombreEssai; }
            set { m_nombreEssai=value; }
        }

        public void plusOuMoins(int guess)
        { 

            if (m_nombreEssai == 0)
            {
                Console.WriteLine("C'est perdu!");
                Console.WriteLine("Il fallait trouver le nombre: " + m_nombreInconnu.ToString() );
                m_nombreEssai--;
            }
            else
            {
                if (guess < m_nombreInconnu)
                {
                    Console.WriteLine("C'est plus !");
                    Console.WriteLine("Il vous reste " + m_nombreEssai.ToString() + " tentatives");
                    m_nombreEssai--;
                }
                else if (guess > m_nombreInconnu)
                {
                    Console.WriteLine("C'est moins !");
                    Console.WriteLine("Il vous reste " + m_nombreEssai.ToString() + " tentatives");
                    m_nombreEssai--;
                }
                else
                {
                    Console.WriteLine("Bravo! Vous avez trouvez!");
                }
            }
        }

        private int m_nombreInconnu;
        private int m_nombreEssai;
    }
}
