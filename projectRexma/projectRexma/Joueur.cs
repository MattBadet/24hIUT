using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace projectRexma
{
    public class Joueur
    {

        #region Attributs
        // Camp du joueur
        private string camp;
        private TcpClient client;
        private StreamReader fluxEntrant;
        private StreamWriter fluxSortant;
        private int nbtours;
        private string ordre;
        // Ordre du joueur par rapport aux autres
        private int numeroOrdre;
        public int NumeroOrdre { get => numeroOrdre; set => numeroOrdre = value; }


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

        private void Connexion()
        {
            this.client = new TcpClient("127.0.0.1", 1234);
        }
        private void CreationFlux()
        {
            this.fluxEntrant = new StreamReader(client.GetStream());
            this.fluxSortant = new StreamWriter(client.GetStream());
            this.fluxSortant.AutoFlush = true;
        }


        // Piocher une carte
        public void Piocher(string numeroCarte)
        {
            // Piocher la carte demandée
            this.fluxSortant.WriteLine($"PIOCHER|{numeroCarte}");
            // Réagir à la réponse du serveur

            //Ajouter la carte dans la liste
            //this.main.AjouterCarte()
        }

        // renvoie le nombre de carte du joueur actuelle
        public int RetournerNbCarte()
        {
            return this.main.nbCartes;
        }


        public void Saboter(int direction)
        {
            Console.WriteLine($"SABOTAGE|{direction}");
        }

        //public string MainJoueur(string mess)
        //{
        //    string[] message = mess.Split("|");
        //    return "";
        //}
        public void Pioche(string mess)
        {
            string[] message = mess.Split("|");
            //réfléchir quoi piocher
        }
        public string Sommet(string mess)
        {
            string[] message = mess.Split("|");
            return "";
        }
        public void Start()
        {
            this.Connexion();
            this.CreationFlux();
            Console.WriteLine("-- Début de la partie --");
            this.fluxSortant.WriteLine("INSCRIRE");
            ordre = this.fluxEntrant.ReadLine().Split('|')[1];
        
            while (nbtours < 100)
            {
                //Analyse de la main
                this.fluxEntrant.ReadLine();
                // analyse de la Pioche et il pioche
                this.fluxSortant.WriteLine("Sommet");
                string pioche = this.fluxEntrant.ReadLine();
                // création bouteille ? donc défausser

                if (TypeCarte.BOUTEILLE > 0)
                {

                }              
                    

                
                nbtours += 1;
            }
            Console.WriteLine("-- Fin de la partie --");



        }

        #endregion



    }
}