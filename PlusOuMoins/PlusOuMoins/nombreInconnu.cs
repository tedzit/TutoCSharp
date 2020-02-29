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

        public int Nombre
        {
            get { return m_nombreInconnu; }
        }
        public int Essai
        {
            get { return m_nombreEssai; }
        }

        public void plusOuMoins(int guess)
        { 
            if (guess < m_nombreInconnu)
            {
                Console.WriteLine("C'est plus !");
            }
            else if (guess > m_nombreInconnu)
            {
                Console.WriteLine("C'est moins !");
            }
            else
            {
                Console.WriteLine("Bravo! Vous avez trouvez!");
            }

            if (m_nombreEssai == 0)
            {
                Console.WriteLine("C'est perdu!");
                Console.WriteLine("Il fallait trouver le nombre: " + m_nombreInconnu.ToString() );
                m_nombreEssai--;
            }
            else
            {
                Console.WriteLine("Il vous reste " + m_nombreEssai.ToString() + " tentatives");
                m_nombreEssai--;
            }
        }

        private int m_nombreInconnu;
        private int m_nombreEssai;
    }
}
