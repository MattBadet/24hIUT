using System;
using System.Collections.Generic;
using System.Text;

namespace projectRexma
{
    public class Main
    {
        #region attribut

        // Renvoie nombre de cartes
        public int nbCartes
        {
            get { return this.cartes.Count; }
        }

        // Liste des cartes du joueur
        private List<Carte> cartes;

        #endregion



        #region methodes

        // Création de la liste de main avec 0 cartes
        public Main()
        {
            this.cartes = new List<Carte>();
        }


        // Ajout d'une carte dans la main
        public void AjouterCarte(TypeCarte type)
        {
            Carte carte = new Carte(type);
            cartes.Add(carte);

        }

        // Suppresion d'une carte de la main
        public void EnleverCarte(int positionListe)
        {
            
            cartes.RemoveAt(positionListe);

        }

        #endregion



    }
}
