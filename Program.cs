using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal? resultatTotal = null;
            string readlineOutput;
            bool isAdd = false;
            bool isSub = false;
            bool isDiv = false;
            bool isMult = false;

            Console.WriteLine("Bonjour et bienvenue dans la calculatrice c# faite par Yann.");
            Console.WriteLine("Pour utiliser a bon escient la calculatrice, suivez les commandes ci-dessous.");
            Console.WriteLine();

            do
            {
                Console.Write("* : Multiplication\n");
                Console.Write("/ : Division\n");
                Console.Write("- : Soustraction\n");
                Console.Write("+ : Addition\n");
                Console.Write("Q : Quitter l'application\n");
                Console.Write("R : Reset le chiffre du calcul\n");
                Console.Write("C : Clear la console\n\nVotre choix > ");

                string calc = Console.ReadLine();
                switch (calc)
                {
                    case "+":
                        {
                            isAdd = true;
                            break;
                        }
                    case "-":
                        {
                            isSub = true;
                            break;
                        }
                    case "*":
                        {
                            isMult = true;
                            break;
                        }
                    case "/":
                        {
                            isDiv = true;
                            break;
                        }
                    case "C":
                        Console.Clear();
                        continue;
                    case "Q":
                        return;
                    case "R":
                         resultatTotal = null;
                        continue;
                    default:
                        Console.WriteLine("Vous n'avez choisi aucun calcul. Veuillez choisir une valeur correspondante. (*  /  -  +  C  Q)");
                        continue;
                }

                decimal? firstDecimal;
                if (!resultatTotal.HasValue)
                {
                    do
                    {
                        Console.WriteLine("Entrez le nombre 1 : ");
                        readlineOutput = Console.ReadLine();
                        firstDecimal = StringToDecimal(readlineOutput);
                    } while (firstDecimal is null);
                }
                else
                {
                    firstDecimal = resultatTotal;
                }

                decimal? secondDecimal;
                do
                {
                    Console.WriteLine("Entrez le nombre 2 : ");
                    readlineOutput = Console.ReadLine();
                    secondDecimal = StringToDecimal(readlineOutput);
                } while (secondDecimal is null);

                if (isSub)
                {
                    resultatTotal = firstDecimal.Value - secondDecimal.Value;
                }
                else if (isAdd)
                {
                    resultatTotal = firstDecimal.Value + secondDecimal.Value;
                }
                else if (isDiv)
                {
                    resultatTotal = firstDecimal.Value / secondDecimal.Value;
                }
                else if (isMult)
                {
                    resultatTotal = firstDecimal.Value * secondDecimal.Value;
                }

                PrintResult(resultatTotal.Value);

                isAdd = isSub = isDiv = isMult = false;

            } while (true);
        }

        private static decimal? StringToDecimal(string inputString)
        {
            var numberFortmatSeparatedByComa = new CultureInfo("en-US").NumberFormat;
            var numberFortmatSeparatedByDot = new CultureInfo("fr-CH").NumberFormat;

            if (!decimal.TryParse(inputString, NumberStyles.Any, numberFortmatSeparatedByDot, out decimal result))
            {
                if (!decimal.TryParse(inputString, NumberStyles.Any, numberFortmatSeparatedByComa, out result))
                {
                    return null;
                }
            }
            return result;
        }

        private static void PrintResult(decimal result)
        {
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine("votre résultat est : " + result);
            Console.WriteLine("======================");
            Console.WriteLine();
        }
    }
}
