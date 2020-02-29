using System;

/// <summary>
/// Description résumée de nombreInconnu
/// Classe permettant l'initialisation d'un nombre aléatoire
/// </summary>
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
