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
        public void AjouterCarte(TypeCarte type,int nbCarte)
        {   
            
            for (int i = 0; i < nbCarte; i++)
            {
                Carte carte = new Carte(type);
                cartes.Add(carte);
            }

        }

        // Suppresion d'une carte de la main
        public void EnleverCarte(TypeCarte type, int nbCarte)
        {
            int i = 0;
           
                foreach (Carte c in this.cartes)
                {
                    if ( (c.TypeCarte == type) && (i <= nbCartes) )
                    {
                        cartes.Remove(c);
                        i = i+1;
                    }
                }   

        }

        // Renvoie le type de carte dont la valeur est la plus grande
        public TypeCarte calculMain()
        {
            int nbAligote = 0;
            int nbChardonnay = 0;
            int nbGamay = 0;
            int nbPinoy = 0;


            foreach (Carte c in this.cartes)
            {
                if (c.TypeCarte == TypeCarte.CHARDONNAY)
                {
                    nbChardonnay += 1;
                }
                else if (c.TypeCarte == TypeCarte.ALIGOTE)
                {
                    nbAligote += 1;
                }
                else if (c.TypeCarte == TypeCarte.GAMAY)
                {
                    nbGamay += 1;
                }
                else if (c.TypeCarte == TypeCarte.PINOY)
                {
                    nbPinoy += 1;
                }

            }

            double valeurAligote = nbAligote * nbAligote * 0.8;
            double valeurChardonnay = nbChardonnay * nbChardonnay * 1.0;
            double valeurGamay = nbGamay * nbGamay * 0.9;
            double valeurPinoy = nbPinoy * nbPinoy * 1.2;


            TypeCarte meilleurType = TypeCarte.NULL;
            if (valeurPinoy > 30)
            {
                meilleurType = TypeCarte.PINOY;
            }
            else if (valeurChardonnay > 30)
            {
                meilleurType = TypeCarte.CHARDONNAY;
            }
            else if (valeurGamay > 30)
            {
                meilleurType = TypeCarte.GAMAY;
            }
            else if (valeurAligote > 30)
            {
                meilleurType = TypeCarte.ALIGOTE;
            }

            return meilleurType;
        }
        #endregion



    }
}
