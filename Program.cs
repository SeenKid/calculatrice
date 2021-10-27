using System;
using System.Collections.Generic;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("* : Multiplication\n");
                Console.Write("/ : Division\n");
                Console.Write("- : Soustraction\n");
                Console.Write("+ : Addition\n");
                Console.Write("C : Clear la console\n\nVotre choix : ");
                //Console.ReadLine();

                string calc = Console.ReadLine();
                switch (calc)
                {
                    case "+":
                        {
                            /* Addition */
                            Console.WriteLine("Entrez le nombre 1 : ");
                            var readlineOutput = Console.ReadLine();
                            if (!int.TryParse(readlineOutput, out int result))
                            {
                                Console.WriteLine("Valeur invalide.");
                                break;
                            }
                            Console.WriteLine("Entrez le nombre 2 : ");
                            var readlineOutput1 = Console.ReadLine();
                            if (!int.TryParse(readlineOutput1, out int result1))
                            {
                                Console.WriteLine("Valeur invalide.");
                                break;
                            }
                            int final = result + result1;
                            Console.WriteLine("======================");
                            Console.WriteLine("votre résultat est : " + final);
                            //Console.WriteLine("votre résultat est : " + final);
                            Console.WriteLine("======================");
                            Console.WriteLine();
                            break;
                        }
                    case "*":
                        /* Multiplication */
                        Console.WriteLine("Entrez le nombre 1 : ");
                        var readlineOutput2 = Console.ReadLine();
                        if (!int.TryParse(readlineOutput2, out int result2))
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }
                        Console.WriteLine("Entrez le nombre 2 : ");
                        var readlineOutput3 = Console.ReadLine();
                        if (!int.TryParse(readlineOutput3, out int result3))
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }
                        int final1 = result3 * result3;
                        Console.WriteLine();
                        Console.WriteLine("======================");
                        Console.WriteLine("votre résultat est : " + final1);
                        //Console.WriteLine("votre résultat est : " + final1);
                        Console.WriteLine("======================");
                        Console.WriteLine();
                        break;
                    case "-":
                        /* Soustraction */
                        Console.WriteLine("Entrez le nombre 1 : ");
                        var readlineOutput4 = Console.ReadLine();
                        if (!int.TryParse(readlineOutput4, out int result4))
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }
                        Console.WriteLine("Entrez le nombre 2 : ");
                        var readlineOutput5 = Console.ReadLine();
                        if (!int.TryParse(readlineOutput5, out int result5))
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }
                        int final2 = result4 - result5;
                        Console.WriteLine("======================");
                        Console.WriteLine("votre résultat est : " + final2);
                        //Console.WriteLine("votre résultat est : " + final2);
                        Console.WriteLine("======================");
                        Console.WriteLine();
                        break;
                    case "/":
                        /* Division */
                        Console.WriteLine("Entrez le nombre 1 : ");
                        var readlineOutput6 = Console.ReadLine();
                        if (!int.TryParse(readlineOutput6, out int result6))
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }
                        Console.WriteLine("Entrez le nombre 2 : ");
                        var readlineOutput7 = Console.ReadLine();
                        if (!int.TryParse(readlineOutput7, out int result7))
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }
                        int final3 = result6 / result7;
                        Console.WriteLine("======================");
                        Console.WriteLine("votre résultat est : " + final3);
                        //Console.WriteLine("votre résultat est : " + final3);
                        Console.WriteLine("======================");
                        Console.WriteLine();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Vous n'avez choisi aucun calcul. La calculatrice c'est arrêtée.");
                        break;
                }
            } while (true);
        } 
    }
}
