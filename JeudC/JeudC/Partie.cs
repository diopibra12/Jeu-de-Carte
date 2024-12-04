using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudC
{
<<<<<<< HEAD
    internal class Partie
    {
=======
<<<<<<< HEAD
    internal class Partie
    {
=======
   public class Partie : IObservateur
    {
        private Random random = new Random();
        private List<Joueur> joueur;
        private List<Carte> cartes { get; }
        private Depot depot;
        private Pioche pioche;
        public Partie(List<Joueur> j, Depot d, Pioche p)
        {
            joueur = j;
            depot = d;
            pioche = p;
        }

        public void MettreAJour(string message)
        {
            Console.WriteLine(message);
        }
        public Joueur InitialiserPartie()
        {
            // Créer un jeu de 32 cartes
            List<Carte> jeuDeCartes = CreerJeuDe32Cartes();
            // Mélanger le jeu de cartes
            MélangerCartes(jeuDeCartes);
            // Choisir aléatoirement le premier joueur
            int premierJoueurIndex = random.Next(joueur.Count);
            Joueur premierJoueur = joueur[premierJoueurIndex];
            // Distribuer les cartes aux joueurs
            DistribuerCartes(jeuDeCartes, premierJoueurIndex);
            // Placer le reste des cartes dans la pioche
            pioche.InitialiserPioche(jeuDeCartes);
            MettreAJour(premierJoueur.JouerLaPremiereCarte());
            premierJoueur = GetJoueurSuivant(premierJoueur);
            return premierJoueur;
        }

        private List<Carte> CreerJeuDe32Cartes()
        {
            List<Carte> jeuDeCartes = new List<Carte>();

            foreach (EnumCouleur couleur in Enum.GetValues(typeof(EnumCouleur)))
            {

                foreach (EnumValeur valeur in Enum.GetValues(typeof(EnumValeur)))
                {
                    jeuDeCartes.Add(new Carte(valeur, couleur));
                }
            }

            return jeuDeCartes;
        }


        private void MélangerCartes(List<Carte> cartes)
        {
            // Mélanger les cartes

        }

        //distribue cartes aléatoirement au debut du jeu
        private void DistribuerCartes(List<Carte> jeuDeCartes, int premierJoueurIndex)
        {
            int nombreDeCartesParJoueur = 8;
            Joueur joueurCourant = joueur[0];
            Carte carte = jeuDeCartes[0];
            for (int i = 0; i < joueur.Count; i++)
            {
                joueurCourant = joueur[(i + premierJoueurIndex) % joueur.Count];
                for (int j = 0; j < nombreDeCartesParJoueur; j++)
                {
                    if (jeuDeCartes.Count > 0)
                    {
                        int index = random.Next(jeuDeCartes.Count);
                        carte = jeuDeCartes[index];
                        joueurCourant.Main.Add(carte);
                        jeuDeCartes.RemoveAt(index);
                    }
                }
            }
        }

        //lance la partie 
        public async Task JouerPartie()
        {
            // Mise en place du jeu
            Joueur joueurCourant = InitialiserPartie();
            while (true)
            {
                string message = $"{joueurCourant.Nom} c'est à votre tour.";
                MettreAJour(message);
                // Le joueur joue une carte
                Carte derniereCarteDepot = Depot.cartesDeposees.Peek();
                string messageCarteJouee = joueurCourant.JouerTour(derniereCarteDepot);
                MettreAJour(messageCarteJouee);
                string messageDerniereCarteDepot = $"Dernière carte sur la pile de dépôt : {Depot.cartesDeposees.Peek()}.";
                MettreAJour(messageDerniereCarteDepot);
                if (joueurCourant.ATermine())
                {
                    // Le joueur a terminé ses cartes, il a gagné
                    string messageVictoire = $"{joueurCourant.Nom} a gagné la partie !";
                    MettreAJour(messageVictoire);
                    break; // Sortir de la boucle
                }
                // Changez de joueur pour le tour suivant
                joueurCourant = GetJoueurSuivant(joueurCourant);

                // Ajoutez un délai de 2 secondes entre les tours
                await Task.Delay(1000);
            }
        }

        //passe au joueur suivant
        private Joueur GetJoueurSuivant(Joueur joueurCourant)
        {
            int indexCourant = joueur.IndexOf(joueurCourant);
            int indexSuivant = (indexCourant + 1) % joueur.Count;
            return joueur[indexSuivant];
        }

>>>>>>> 8b6b9c2cacf186e561c12971cb81cbf5ad89643b
>>>>>>> 77bc99d48b166c8c54984473244c4d469e00109d
    }
}
