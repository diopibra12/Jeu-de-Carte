<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudC
{
    public class Program
    {
        static async Task Main()
        {
            Joueur j1 = new Joueur("Alice","Benga",1);
            Joueur j2 = new Joueur("Bob","Marley",2);
            Joueur j3 = new Joueur("Charlie","Puth",3);
            List<Joueur> joueurs = new List<Joueur> { j1,j2,j3 };
            Depot depot = new Depot();
            Pioche pioche = new Pioche();
            Partie partie = new Partie(joueurs, depot, pioche);
            await partie.JouerPartie();
        }
    }
}
=======
﻿
>>>>>>> 8b6b9c2cacf186e561c12971cb81cbf5ad89643b
