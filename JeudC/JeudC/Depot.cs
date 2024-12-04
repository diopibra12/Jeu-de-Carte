using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudC
{
<<<<<<< HEAD
    public class Depot
    {
        public static Stack<Carte> cartesDeposees;

        public Stack<Carte> CartesDeposees
        {
            get { return cartesDeposees; }
            set { cartesDeposees = value; }

        }

        public Depot()
        {
            cartesDeposees = new Stack<Carte>();
        }

        // Méthode pour ajouter une carte au dépôt
        public void AjouterCarte(Carte carte)
        {
            cartesDeposees.Push(carte);
        }

        // Méthode pour recuperer la dernière carte jouée
        public Carte GetLastCartesDeposees()
        {
            return cartesDeposees.Pop();
        }


        // Méthode pour vider le dépôt
        public void ViderDepot()
        {
            cartesDeposees.Clear();
        }

        //permet de melanger les cartes du depot pour reconstituer la pioche
        public static void MelangerCartesDepot()
        {

            List<Carte> cartesList = cartesDeposees.ToList();
            Random random = new Random();
            int n = cartesList.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Carte carteTemp = cartesList[k];
                cartesList[k] = cartesList[n];
                cartesList[n] = carteTemp;
            }

            //reconstruire la pile de pioche à partir des cartes déposées
            cartesDeposees = new Stack<Carte>(cartesList);
        }


=======
    internal class Depot
    {
>>>>>>> 77bc99d48b166c8c54984473244c4d469e00109d
    }
}
