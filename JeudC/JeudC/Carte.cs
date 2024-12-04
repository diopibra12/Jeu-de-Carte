using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudC
{
<<<<<<< HEAD
    public class Carte
    {
        public EnumValeur valeur { get; private set; }
        public EnumValeur Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public EnumCouleur Couleur { get; private set; }
        public Carte() { }
        public Carte(EnumValeur valeur, EnumCouleur couleur)
        {
            this.Couleur = couleur;
            this.valeur = valeur;
        }
        public override string ToString()
        {
            return $"{valeur} de {Couleur}";
        }

=======
<<<<<<< HEAD
    public class Carte
=======
    internal class Carte
>>>>>>> 8b6b9c2cacf186e561c12971cb81cbf5ad89643b
    {
>>>>>>> 77bc99d48b166c8c54984473244c4d469e00109d
    }
}
