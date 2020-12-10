using System;

namespace jeu_du_pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "oui";
            while (recommencer=="oui")
            {
                string mot;
                bool essai = false;
                string tentative;
                int chances = 0;
                int ocurences = 0;
                Console.WriteLine("Jeu du pendu \nJoueur 1 veuillez entrer un mot d'au moins cinq lettres, sans accent ni majuscule");
                mot = Console.ReadLine(); //Création d'un tableau contenant le mot de l'utilisateur
                Console.Clear(); //effacer le mot
                if (mot.Length < 5) // Si la taille du mot est inférieure à cinq lettres
                {
                    Console.WriteLine("Taille du mot incorrecte, le mot doit contenir au moins 5 lettres"); //Renvoyer à la fin
                }
                else // Si la taille du tableau est supérieure à 5
                {
                    char[] devinette = new char[mot.Length] ; //créer un tableau de string pour afficher la devinette
                    for (int i =0; i<devinette.Length;i++) //pour chaque ligne du tableau
                    {
                        Console.Write(" _ "); // afficher "_" avec une séparation
                    }
                    Console.WriteLine("\n \nIl y a " + devinette.Length + " lettres à deviner"); //afficher le nombre de lettres a deviner
                    do
                    {
                        Console.WriteLine("\nJoueur deux, veuillez entrer une lettre ");
                        tentative = Console.ReadLine(); // Affectation d'une string au contenu de la variable "tentative"
                        for (int i = 0; i < mot.Length; i++) // Vérifier toutes les lettres du mot
                        {
                            if (mot[i] == tentative[0]) // Si la lettre qu'a entré le joueur 2 n'est pas présente dans le mot
                            {
                                essai = true;
                            }
                        }
                        if (essai) //Si la lettre est présente dans le mot
                        {
                            Console.WriteLine("La lettre est bien présente dans le mot");
                            for (int y = 0; y < mot.Length; y++)
                            {
                                if (mot[y] == tentative[0])
                                {
                                    devinette[y] = tentative[0];
                                }
                            }
                            Console.WriteLine(devinette);
                        }
                        else if (!essai) //Si la lettre n'est pas présente dans le mot
                        {
                            chances++; //Enlever une chance
                            Console.WriteLine("Raté ! Vous avez fait " + chances + " erreur(s) sur 7"); //Afficher les chances restantes
                        }
                        essai = false; //Réinitialiser la position d'essai
                    }
                    while (chances < 7 && devinette != mot.ToCharArray()); //Tant que le joueur a encore des chances ou que le joueur n'a pas trouvé toutes les lettres
                    if (chances == 7 && devinette != mot.ToCharArray()) // si le joueur 2 a dépensé toutes ses chances et qu'il n'a pas trouvé toutes les lettres
                    {
                        Console.WriteLine("Joueur 2 a perdu !!!");// le joueur 2 a perdu
                    }
                    else if (chances < 7 && devinette == mot.ToCharArray()) //si le joueur 2 a encore des chances et qu'il a deviné toutes les lettres
                    {
                        Console.WriteLine("Joueur 2 a gagné !!!"); // le joueur 2 gagne 
                    }
                }
                

            }
            

        }
    }
}
