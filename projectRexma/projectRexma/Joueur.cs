using System;
using System.Collections.Generic;
using System.Text;

namespace projectRexma
{
    public class Joueur
    {

        #region Attributs
        // Camp du joueur
        private string camp;

        // Ordre du joueur par rapport aux autres
        private int numeroOrdre;


        // Main du joueur
        private Main main;

        #endregion


        #region Methodes
        // Création d'un joueur
        public Joueur(String camp)
        {
            this.camp = camp;
            this.main = new Main();
        }


        // Piocher une carte
        public void Piocher(string numeroCarte)
        {
            // Piocher la carte demandée
            Console.WriteLine($"PIOCHER|{numeroCarte}");
            // Réagir à la réponse du serveur

            //Ajouter la carte dans la liste
            //this.main.AjouterCarte()
        }

        #endregion
    }
}
