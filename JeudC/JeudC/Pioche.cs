<<<<<<< HEAD
﻿using System;
=======
<<<<<<< HEAD
﻿using JeudC;
using System;
=======
﻿using System;
>>>>>>> 8b6b9c2cacf186e561c12971cb81cbf5ad89643b
>>>>>>> 77bc99d48b166c8c54984473244c4d469e00109d
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudC
{
<<<<<<< HEAD
=======
<<<<<<< HEAD

    public class Pioche
    {
        public static Stack<Carte> pileDeCartes = new Stack<Carte>();
        public Stack<Carte> PileDeCartes
        {
            get { return pileDeCartes; }
            set { pileDeCartes = value; }
        }


        //public Stack<Carte> GetPileDeCartes() { return pileDeCartes; }
        public Pioche() { }
        public Pioche(List<Carte> cartes)

        {
            // Initialisez la pile de cartes à partir de la liste passée en paramètre
            InitialiserPioche(cartes);
        }

        // Méthode pour piocher une carte de la pioche
        public static void PiocherCarte(Joueur j)
        {
            if (pileDeCartes.Count > 0)
            {
                j.Main.Add(pileDeCartes.Pop());
            }
            else
            {
                Depot.MelangerCartesDepot();
                pileDeCartes = Depot.cartesDeposees;
                j.Main.Add(pileDeCartes.Pop());
                Depot.cartesDeposees = new Stack<Carte>();
            }
        }

        //initialise ma pioche
        public void InitialiserPioche(List<Carte> jeuDeCartes)
        {
            // s'assure que la pioche est vide
            if (EstVide())
                for (int i = jeuDeCartes.Count - 1; i >= 0; i--)
                {
                    pileDeCartes.Push(jeuDeCartes[i]);
                }
        }


        // Méthode pour vérifier si la pioche est vide
        public bool EstVide()
        {
            return pileDeCartes.Count == 0;
        }
    }

}

=======
>>>>>>> 77bc99d48b166c8c54984473244c4d469e00109d
    internal class Pioche
    {
    }
}
<<<<<<< HEAD
=======
>>>>>>> 8b6b9c2cacf186e561c12971cb81cbf5ad89643b
>>>>>>> 77bc99d48b166c8c54984473244c4d469e00109d
