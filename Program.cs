using System;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("* : Multiplication\n");
            Console.Write("/ : Division\n");
            Console.Write("- : Soustraction\n");
            Console.Write("+ : Addition\n");
            //Console.ReadLine();

            string calc = Console.ReadLine();
            switch (calc)
            {
                case "+":
                    /* Addition */
                    Console.Write("Entrez le nombre 1 : \n");
                    var num1 = Console.ReadLine();
                    if (!int.TryParse(num1, out int resulta1))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    Console.Write("Entrez le nombre 2 : \n");
                    var num2 = Console.ReadLine();
                    if (!int.TryParse(num2, out int result2))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    int finala = result2 + resulta1;
                    Console.WriteLine("======================");
                    Console.Write("votre résultat est : " + finala + "\n");
                    break;
                case "*":
                    /* Multiplication */
                    Console.Write("Entrez le nombre 1 : \n");
                    var maValeur = Console.ReadLine();
                    if (!int.TryParse(maValeur, out int result))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    var num3 = Console.ReadLine();
                    if (!int.TryParse(num3, out int result3))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    Console.Write("Entrez le nombre 2 : \n");
                    var num4 = Console.ReadLine();
                    if (!int.TryParse(num4, out int resulta))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    int finalm = result3 * resulta;
                    Console.WriteLine();
                    Console.WriteLine("======================");
                    Console.WriteLine("votre résultat est : " + finalm);
                    break;
                case "-":
                    /* Soustraction */
                    Console.Write("Entrez le nombre 1 : \n");
                    var num5 = Console.ReadLine();
                    if (!int.TryParse(num5, out int result5))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    Console.Write("Entrez le nombre 2 : \n");
                    var num6 = Console.ReadLine();
                    if (!int.TryParse(num6, out int result6))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    int finals = result5 - result6;
                    Console.WriteLine("======================");
                    Console.Write("votre résultat est : " + finals + "\n");
                    break;
                case "/":
                    /* Division */
                    Console.Write("Entrez le nombre 1 : \n");
                    var num7 = Console.ReadLine();
                    if (!int.TryParse(num7, out int result7))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    Console.Write("Entrez le nombre 2 : \n");
                    var num8 = Console.ReadLine();
                    if (!int.TryParse(num8, out int result8))
                    {
                        Console.WriteLine("Valeur invalide.");
                        break;
                    }
                    int finald = result7 / result8;
                    Console.WriteLine("======================");
                    Console.Write("votre résultat est : " + finald + "\n");
                    break;
                default:
                    Console.Write("Vous n'avez choisi aucun calcul. La calculatrice c'est arrêtée.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
