using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Bataille_Winform
{
    public partial class gameForm : Form
    {
        // Modélisation du jeu : Déclarer les variables
        public const int PIQUE = 0, COEUR = 1, CARREAU = 2, TREFLE = 3; // couleurs

        public const int SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13, AS = 14; // figures

        public static int[] carte = new int[32];
        public static int[] couleur = new int[32];

        // Todo - Déclarer les Queue et les stack ...

        //Paquet de cartes
        public static int[] jeu = new int[32];

        public static Queue<int> partie = new Queue<int>(32);

        //Tas de chaque joueurs
        public static Queue<int> josse = new Queue<int>();

        public static Queue<int> lulu = new Queue<int>();

        public static Stack<int> Tapis = new Stack<int>();

        public static int numTour = 0;

        public static void CreerCarte(ListBox liste)
        {
            partie.Clear();
            josse.Clear();
            lulu.Clear();
            Tapis.Clear();

            ConsoleWrite(liste, "⏲️ Création des cartes. Veuillez patienter ...");
            ConsoleWrite(liste, " ");

            int k = 0;

            for (int c = 0; c < 4; c++) //boucle pour chaque couleur
            {
                for (int f = 7; f < 15; f++) //Boucle pour chaque carte, on prends les nombres de 7 à 15
                {
                    carte[k] = f; //Ajout de la carte en fonction de l'itération en cours
                    couleur[k] = c; //Ajout de la couleur en fonction de l'itération en cours
                    k++; //Ajoute 1 au competeur d'indice des tableaux
                };
            };

            Thread.Sleep(2000);

            ConsoleWrite(liste, "✅ Création des cartes réussie !");
            ConsoleWrite(liste, " ");
        }

        public static void BattreCarte(ListBox liste)
        {
            ConsoleWrite(liste, "⌛ Mélange des cartes en cours. Veuillez patienter ...");
            ConsoleWrite(liste, " ");

            // Ajoute au tableau toutes les valeurs de 0 à 31
            jeu = Enumerable.Range(0, 32).ToArray();

            Random rnd = new Random();

            // Pour chaque valeur du tableuau
            for (int i = 0; i < jeu.Length; i++)
            {
                int j = rnd.Next(i, jeu.Length); // On génère un nombre entre le l'index du tableau et le nombre de valeurs du tableau

                int temp = jeu[i]; // On stoque la valeur de l'itération dans une variable temp
                jeu[i] = jeu[j]; // On inverse la valeur de litération avec la valeur de l'index générée
                jeu[j] = temp; // On remplace la valeur par la valeur temporaire
            }

            foreach (int carte in jeu)
            {
                //Console.WriteLine(carte);
                partie.Enqueue(carte);
            };

            Thread.Sleep(2000);

            ConsoleWrite(liste, "✅ Mélange des cartes terminé !");
            ConsoleWrite(liste, " ");
        }

        public static void CouperJeu(ListBox liste)
        {
            ConsoleWrite(liste, "⏲️ Le jeu va être coupé, Veuillez patienter ...");
            ConsoleWrite(liste, " ");

            //gestion de la file

            var listeCartesPartie = partie.ToList(); //On copie la file dans une liste
            partie.Clear(); //on vide la file ou se trouve toutes les cartes

            //Gestion de la carte pioche

            int numCarteJosse = int.Parse(Interaction.InputBox("Josse entrez un nombre entre 2 et 31", "", ""));

            while (numCarteJosse < 2 || numCarteJosse > 31)
            {
                numCarteJosse = int.Parse(Interaction.InputBox("Josse le nombre entré n'est pas valide, donnez un nouveau nombre entre 2 et 31", "", ""));
            };

            ConsoleWrite(liste, identifyCard("Josse", numCarteJosse));
            ConsoleWrite(liste, " ");

            Thread.Sleep(2000);

            int numCarteLulu = int.Parse(Interaction.InputBox("Lulu entrez un nombre entre 2 et 31", "", ""));

            while (numCarteLulu < 2 || numCarteLulu > 31)
            {
                numCarteLulu = int.Parse(Interaction.InputBox("Lulu le nombre entré n'est pas valide, donnez un nouveau nombre entre 2 et 31", "", ""));
            };

            ConsoleWrite(liste, identifyCard("Lulu", numCarteLulu));
            ConsoleWrite(liste, " ");
            ConsoleWrite(liste, "⏲️ Le jeu est entrain d'être coupé !");
            ConsoleWrite(liste, " ");

            Thread.Sleep(2000);

            //Gestion du coupage des cartes
            josse.Enqueue(numCarteJosse);
            lulu.Enqueue(numCarteLulu);

            for (int c = 0; c < listeCartesPartie.Count; c++)
            {
                /* Vérification du nombre entré avec les valeurs du tableau
                 * Reconstruction de la file de carte qui constitue la partie
                 */

                if (listeCartesPartie[c] == numCarteJosse)
                    continue;
                else if (listeCartesPartie[c] == numCarteLulu)
                    continue;
                else
                    partie.Enqueue(listeCartesPartie[c]);
            };

            ConsoleWrite(liste, "✅ Le jeu est coupé !");
            ConsoleWrite(liste, " ");
        }

        public static void Distribuerjeu(ListBox liste)
        {
            ConsoleWrite(liste, "⏳ Distribution des cartes en cours ...");
            ConsoleWrite(liste, " ");

            for (int i = 0; i < (partie.Count / 2); i++)
            {
                josse.Enqueue(partie.Dequeue()); // remplissage tas de carte de Josse
                lulu.Enqueue(partie.Dequeue());  // remplissage tas de carte de Lulu
            }

            ConsoleWrite(liste, "✅ Distribution des cartes terminée ...");
            ConsoleWrite(liste, " ");
        }

        public static void Jeu(ListBox liste)
        {
            ConsoleWrite(liste, "🎮 Lancement du jeu ...");
            ConsoleWrite(liste, " ");

            Thread.Sleep(2000);

            while (josse.Count > 0 || lulu.Count > 0)
            {
                if (josse.Count == 0)
                {
                    break;
                }
                else if (lulu.Count == 0)
                {
                    break;
                }
                else
                {
                    int carteJosse = josse.Dequeue();
                    int carteLulu = lulu.Dequeue();

                    ConsoleWrite(liste, "\u231B Tour N°" + (numTour + 1) + " En cours ...");
                    ConsoleWrite(liste, " ");

                    Thread.Sleep(1000);

                    ConsoleWrite(liste, identifyCard("Josse", carteJosse));
                    ConsoleWrite(liste, identifyCard("Lulu", carteLulu));
                    ConsoleWrite(liste, " ");

                    RamasserPli(carteJosse, carteLulu, liste);

                    numTour++;
                    Thread.Sleep(300);
                };
            };
        }

        public static void RamasserPli(int carteJ, int carteL, ListBox liste)
        {
            // Vériification symboles des cartes

            if (carte[carteJ] > carte[carteL])
            {
                josse.Enqueue(carteL);
                josse.Enqueue(carteJ);

                if (Tapis.Count != 0)
                {
                    Tapis.Reverse();

                    if (Tapis.Count > 2)
                    {
                        for (int i = 0; i < (Tapis.Count / 2); i++)
                        {
                            josse.Enqueue(Tapis.Pop());
                            josse.Enqueue(Tapis.Pop());
                        };
                    }
                    else
                    {
                        josse.Enqueue(Tapis.Pop());
                        josse.Enqueue(Tapis.Pop());
                    };
                }
            }
            else if (carte[carteJ] < carte[carteL])
            {
                lulu.Enqueue(carteJ);
                lulu.Enqueue(carteL);

                if (Tapis.Count != 0)
                {
                    if (Tapis.Count > 2)
                    {
                        for (int i = 0; i < (Tapis.Count / 2); i++)
                        {
                            josse.Enqueue(Tapis.Pop());
                            josse.Enqueue(Tapis.Pop());
                        };
                    }
                    else
                    {
                        josse.Enqueue(Tapis.Pop());
                        josse.Enqueue(Tapis.Pop());
                    };
                };
            }
            else if (carte[carteJ] == carte[carteL])
            {
                Bataille(liste);
            }
        }

        public static void Bataille(ListBox liste)
        {
            if (josse.Count > 0 && lulu.Count > 0)
            {
                Tapis.Push(josse.Dequeue());
                Tapis.Push(lulu.Dequeue());

                if (josse.Count != 0 && lulu.Count != 0)
                {
                    ConsoleWrite(liste, "🃏 Les joueurs ont posé le même symbole ils ajoutent une carte à l'envers");
                    ConsoleWrite(liste, " ");

                    Thread.Sleep(2000);

                    numTour++;

                    ConsoleWrite(liste, "\u231B Tour N°" + (numTour + 1) + " En cours ...");
                    ConsoleWrite(liste, " ");

                    Thread.Sleep(1000);

                    int newCarteJosse = josse.Dequeue();
                    int newCarteLulu = lulu.Dequeue();

                    identifyCard("Josse", newCarteJosse);
                    identifyCard("Lulu", newCarteLulu);

                    RamasserPli(newCarteJosse, newCarteLulu, liste);
                }
            }
        }

        public static void displayWinners(ListBox liste)
        {
            if (josse.Count == 0)
            {
                ConsoleWrite(liste, "La dernière carte de Josse à été posée !");
                ConsoleWrite(liste, " ");
                ConsoleWrite(liste, "🎯 Partie terminée ! La bataille fut longue mais Lulu à toute les cartes en main et à gagné la partie !");
            }
            else if (lulu.Count == 0)
            {
                ConsoleWrite(liste, "La dernière carte de Lulu à été posée !");
                ConsoleWrite(liste, " ");
                ConsoleWrite(liste, "🎯 Partie terminée ! La bataille fut longue mais Josse à toute les cartes en main et à gagné la partie !");
            }
            else
            {
                return;
            }
        }

        public static void ConsoleWrite(ListBox events_List, string text)
        {
            events_List.Items.Add(text);
            events_List.TopIndex = events_List.Items.Count - 1;
        }

        public static string identifyCard(string joueur, int carteJoueur)
        {
            //Détermination Symbole et couleur carte
            int figureCarte = carte[carteJoueur];
            string figureJ = "";

            int couleurCarte = couleur[carteJoueur];
            string couleurJ = "";

            switch (figureCarte)
            {
                case SEPT:
                    figureJ = "SEPT";
                    break;

                case HUIT:
                    figureJ = "HUIT";
                    break;

                case NEUF:
                    figureJ = "NEUF";
                    break;

                case DIX:
                    figureJ = "DIX";
                    break;

                case VALET:
                    figureJ = "VALET";
                    break;

                case DAME:
                    figureJ = "DAME";
                    break;

                case ROI:
                    figureJ = "ROI";
                    break;

                case AS:
                    figureJ = "AS";
                    break;
            };

            switch (couleurCarte)
            {
                case PIQUE:
                    couleurJ = "PIQUE";
                    break;

                case COEUR:
                    couleurJ = "COEUR";
                    break;

                case CARREAU:
                    couleurJ = "CARREAU";
                    break;

                case TREFLE:
                    couleurJ = "TREFLE";
                    break;
            };

            return (joueur + " à pioché la carte " + figureJ + " de " + couleurJ);
        }
    }
}