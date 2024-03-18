using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceBasique
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                Console.WriteLine("Bienvenue dans la calculatrice basique !");
                Console.WriteLine("Veuillez choisir une opération :");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Soustraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Division entière");
                Console.WriteLine("6. Reste de la division entière (modulo)");
                Console.WriteLine("0. Quitter");

                int choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 0)
                {
                    continuer = false;
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Veuillez entrer le premier nombre :");
                        double nombre1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Veuillez entrer le deuxième nombre :");
                        double nombre2 = Convert.ToDouble(Console.ReadLine());

                        double resultat = 0;

                        switch (choix)
                        {
                            case 1:
                                resultat = nombre1 + nombre2;
                                Console.WriteLine("Le résultat de l'addition est : " + resultat);
                                break;
                            case 2:
                                resultat = nombre1 - nombre2;
                                Console.WriteLine("Le résultat de la soustraction est : " + resultat);
                                break;
                            case 3:
                                resultat = nombre1 * nombre2;
                                Console.WriteLine("Le résultat de la multiplication est : " + resultat);
                                break;
                            case 4:
                                if (nombre2 != 0)
                                {
                                    resultat = nombre1 / nombre2;
                                    Console.WriteLine("Le résultat de la division est : " + resultat);
                                }
                                else
                                {
                                    throw new DivideByZeroException("Erreur : division par zéro !");
                                }
                                break;
                            case 5:
                                if (nombre2 != 0)
                                {
                                    resultat = nombre1 / nombre2;
                                    Console.WriteLine("Le résultat de la division entière est : " + (int)resultat);
                                }
                                else
                                {
                                    throw new DivideByZeroException("Erreur : division par zéro !");
                                }
                                break;
                            case 6:
                                if (nombre2 != 0)
                                {
                                    resultat = nombre1 % nombre2;
                                    Console.WriteLine("Le résultat du reste de la division entière est : " + resultat);
                                }
                                else
                                {
                                    throw new DivideByZeroException("Erreur : division par zéro !");
                                }
                                break;
                            default:
                                Console.WriteLine("Choix invalide !");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erreur : veuillez entrer des nombres valides !");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.WriteLine("Appuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
