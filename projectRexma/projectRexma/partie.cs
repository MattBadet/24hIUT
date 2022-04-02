using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace projectRexma
{
    class partie
    {
        private List<Joueur> joueurs = new List<Joueur>();
        private TcpClient client;
        private StreamReader fluxEntrant;
        private StreamWriter fluxSortant;
        private int nbtours;

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
        public void AddJoueurs(Joueur j)
        {
            joueurs.Add(j);
        }
        public void StartPLongue()
        {
            Joueur player1 = new Joueur();
            Joueur player2 = new Joueur();
            Joueur player3 = new Joueur();
            Joueur player4 = new Joueur();
            this.AddJoueurs(player1);
            this.AddJoueurs(player2);
            this.AddJoueurs(player3);
            this.AddJoueurs(player4);
        }
        public void StartPCourte()
        {
            Joueur player1 = new Joueur();
            Joueur player2 = new Joueur();
            this.AddJoueurs(player1);
            this.AddJoueurs(player2);
        }
        public void Start()
        {
            this.Connexion();
            this.CreationFlux();
            this.StartPLongue();
            String messageRecu = "";
            Console.WriteLine("-- Début de la partie --");
            while (nbtours < 100)
            {
                messageRecu = this.fluxEntrant.ReadLine();

                nbtours += 1;
            }
            Console.WriteLine("-- Fin de la partie --");
            


        }
    }
}
