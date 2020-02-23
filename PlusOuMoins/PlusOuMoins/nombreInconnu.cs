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
            m_nonbreInconnu = rand.Next(100);
        }

        public int Nombre
        {
            get { return m_nonbreInconnu; }
        }

        private int m_nonbreInconnu;
    }
}
