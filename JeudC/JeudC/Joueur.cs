using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudC
{
<<<<<<< HEAD
    internal class Joueur
    {
=======
<<<<<<< HEAD
    internal class Joueur
    {
=======
    public class Joueur
    {
        private Random random = new Random();
        public string Nom { get; }
        public string Prenom { get; }
        public int Id { get; }
        public List<Carte> main ;

        //propriétés recevant les cartes qui sont dans la main du joueur 

        public List<Carte> Main {
            get { return main; }
            set { main = value; }
        }


        public Joueur() { }

        //constructeur

        public Joueur(string nom, string prenom, int id)
        {
            Nom = nom;
            Prenom = prenom;
            Id = id;
            main = new List<Carte>();
        }

        

        // Méthode permettant au joueur de jouer une carte
      
        public string JouerUneCarte(Carte carte)
        {
            // Vérifier si la carte est dans la main du joueur
            if (main.Contains(carte))
            {
                main.Remove(carte);   
                Depot.cartesDeposees.Push(carte);
                return $"{Nom} {Prenom} joue la carte de valeur {carte.Valeur} et de couleur: {carte.Couleur}";
            }
            else
            {
                Pioche.PiocherCarte(this);
                return  $"{Nom} {Prenom} a pioché une carte";
            }
        }
        
         // selectionne aleatoirement le joueur qui depose la première carte du jeu
        public string JouerLaPremiereCarte()
        {
            int index = random.Next(Main.Count);
            Carte carte = Main[index];
            main.Remove(carte);
            Depot.cartesDeposees.Push(carte);
            return $"{Nom} {Prenom} joue la carte de valeur {carte.Valeur} et de couleur: {carte.Couleur}";            
        }


        //Méthode pour permettre au joueur suivant de jouer
        public String JouerTour(Carte carteDepot)
        {
            // Vérifier si le joueur a une carte jouable
            Carte carteAJouer = main.Find(carte =>
                  carte.Valeur == carteDepot.Valeur || carte.Couleur == carteDepot.Couleur);
                return JouerUneCarte(carteAJouer);
        }

        // verifie si la main du joueur est vide

        public bool ATermine()
        {
            return main.Count == 0;
        }

       
>>>>>>> 8b6b9c2cacf186e561c12971cb81cbf5ad89643b
>>>>>>> 77bc99d48b166c8c54984473244c4d469e00109d
    }
}
