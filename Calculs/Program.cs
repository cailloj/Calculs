/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool error = false; //saisie de la variable error pour vérification des saisie

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                error = false;
                while (!error)
                {
                    try
                    {
                        // affiche le menu et saisi le choix
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        error = true;
                    }
                    catch
                    {
                        Console.WriteLine("erreur de saisir");
                    }
                }

                // traitement des choix
                // Création du nombre aléatoires 
                val1 = rand.Next(1, 20);
                val2 = rand.Next(1, 10);
                switch (choix)
                {
                    case 1:

                        // saisie de la réponse
                        error = false;
                        while (!error)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                error = true;
                            }
                            catch
                            {
                                Console.WriteLine("erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }
                        
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                        break;

                    case 2:
                        // saisie de la réponse
                        error = false;
                        while (!error)
                        {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                error = true;
                            }
                            catch
                            {
                                Console.WriteLine("erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        break;

                    default:
                        Console.WriteLine("erreur de saisi");
                        break;


                }
                
            }
        }
    }
}
