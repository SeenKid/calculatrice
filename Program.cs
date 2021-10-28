using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal resultatTotal = 0;

            do
            {
                Console.Write("* : Multiplication\n");
                Console.Write("/ : Division\n");
                Console.Write("- : Soustraction\n");
                Console.Write("+ : Addition\n");
                Console.Write("Q : Quitter l'application\n");
                Console.Write("C : Clear la console\n\nVotre choix : ");

                string calc = Console.ReadLine();
                switch (calc)
                {
                    case "+":
                        /* Addition */
                        Console.WriteLine("Entrez le nombre 1 : ");
                        var readlineOutput = Console.ReadLine();
                        decimal? result = StringToDecimal(readlineOutput);
                        if (result is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        Console.WriteLine("Entrez le nombre 2 : ");
                        var readlineOutput1 = Console.ReadLine();
                        decimal? result1 = StringToDecimal(readlineOutput1);
                        if (result is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        decimal final = result.Value + result1.Value;
                        Console.WriteLine("======================");
                        Console.WriteLine("votre résultat est : " + final);
                        Console.WriteLine("======================");
                        Console.Write("Désirez vous continuer votre calcul ?\n(Y = oui et N = non)\n");
                        Console.WriteLine();
                        string calc1 = Console.ReadLine();

                        switch (calc1)
                        {
                            case "Y":
                                Console.WriteLine("Entrez le nombre suivant à calculer : ");
                                var readlineOutputx = Console.ReadLine();
                                decimal? resultx = StringToDecimal(readlineOutputx);
                                if (resultx is null)
                                {
                                    Console.WriteLine("Valeur invalide.");
                                    break;
                                }
                                decimal finalx = final + resultx.Value;
                                Console.WriteLine("======================");
                                Console.WriteLine("votre résultat est : " + finalx);
                                Console.WriteLine("======================");
                                Console.WriteLine();
                                break;
                            case "N":
                                break;
                            default:
                                Console.WriteLine("Le chiffre n'a pas été saisis.");
                                break;
                        }
                        break;
                    case "*":
                        /* Multiplication */
                        Console.WriteLine("Entrez le nombre 1 : ");
                        var readlineOutput2 = Console.ReadLine();
                        decimal? result2 = StringToDecimal(readlineOutput2);
                        if (result2 is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        Console.WriteLine("Entrez le nombre 2 : ");
                        var readlineOutput3 = Console.ReadLine();
                        decimal? result3 = StringToDecimal(readlineOutput3);
                        if (result3 is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        decimal final1 = result2.Value * result3.Value;
                        Console.WriteLine();
                        Console.WriteLine("======================");
                        Console.WriteLine("votre résultat est : " + final1);
                        Console.WriteLine("======================");
                        Console.Write("Désirez vous continuer votre calcul ?\n(Y = oui et N = non)\n");
                        Console.WriteLine();
                        string calc2 = Console.ReadLine();

                        switch (calc2)
                        {
                            case "Y":
                                Console.WriteLine("Entrez le nombre suivant à calculer : ");
                                var readlineOutputy = Console.ReadLine();
                                decimal? resulty = StringToDecimal(readlineOutputy);
                                if (resulty is null)
                                {
                                    Console.WriteLine("Valeur invalide.");
                                    break;
                                }
                                decimal finaly = final1 * resulty.Value;
                                Console.WriteLine("======================");
                                Console.WriteLine("votre résultat est : " + finaly);
                                Console.WriteLine("======================");
                                Console.WriteLine();
                                break;
                            case "N":
                                break;
                            default:
                                Console.WriteLine("Le chiffre n'a pas été saisis.");
                                break;
                        }
                        break;
                    case "-":
                        /* Soustraction */
                        Console.WriteLine("Entrez le nombre 1 : ");
                        var readlineOutput4 = Console.ReadLine();
                        decimal? result4 = StringToDecimal(readlineOutput4);
                        if (result4 is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        Console.WriteLine("Entrez le nombre 2 : ");
                        var readlineOutput5 = Console.ReadLine();
                        decimal? result5 = StringToDecimal(readlineOutput5);
                        if (result5 is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        decimal final2 = result4.Value - result5.Value;
                        Console.WriteLine("======================");
                        Console.WriteLine("votre résultat est : " + final2);
                        Console.WriteLine("======================");
                        do
                        {
                            Console.Write("Désirez vous continuer votre calcul ?\n(Y = oui et N = non)\n");
                            Console.WriteLine();
                            string calc4 = Console.ReadLine();

                            switch (calc4)
                            {
                                case "Y":
                                    Console.WriteLine("Entrez le nombre suivant à calculer : ");
                                    var readlineOutputu = Console.ReadLine();
                                    decimal? resultu = StringToDecimal(readlineOutputu);
                                    if (resultu is null)
                                    {
                                        Console.WriteLine("Valeur invalide.");
                                        break;
                                    }

                                    decimal finalu = final2 - resultu.Value;
                                    Console.WriteLine("======================");
                                    Console.WriteLine("votre résultat est : " + finalu);
                                    Console.WriteLine("======================");
                                    Console.WriteLine();
                                    break;
                                case "N":
                                    break;
                                default:
                                    Console.WriteLine("Le chiffre n'a pas été saisis.");
                                    break;
                            }
                        } while (true);
                    case "/":
                        /* Division */
                        Console.WriteLine("Entrez le nombre 1 : ");
                        var readlineOutput6 = Console.ReadLine();
                        decimal? result6 = StringToDecimal(readlineOutput6);
                        if (result6 is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        Console.WriteLine("Entrez le nombre 2 : ");
                        var readlineOutput7 = Console.ReadLine();
                        decimal? result7 = StringToDecimal(readlineOutput7);
                        if (result7 is null)
                        {
                            Console.WriteLine("Valeur invalide.");
                            break;
                        }

                        decimal final3 = result6.Value / result7.Value;
                        Console.WriteLine("======================");
                        Console.WriteLine("votre résultat est : " + final3);
                        Console.WriteLine("======================");
                        Console.Write("Désirez vous continuer votre calcul ?\n(Y = oui et N = non)\n");
                        Console.WriteLine();
                        string calc3 = Console.ReadLine();

                        switch (calc3)
                        {
                            case "Y":
                                Console.WriteLine("Entrez le nombre suivant à calculer : ");
                                var readlineOutputa = Console.ReadLine();
                                decimal? resulta = StringToDecimal(readlineOutputa);
                                if (resulta is null)
                                {
                                    Console.WriteLine("Valeur invalide.");
                                    break;
                                }
                                decimal finala = final3 / resulta.Value;
                                Console.WriteLine("======================");
                                Console.WriteLine("votre résultat est : " + finala);
                                Console.WriteLine("======================");
                                Console.WriteLine();
                                break;
                            case "N":
                                break;
                            default:
                                Console.WriteLine("Le chiffre n'a pas été saisis.");
                                break;
                        }
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "Q":
                        return;
                    default:
                        Console.WriteLine("Vous n'avez choisi aucun calcul. Veuillez choisir une valeur correspondante. (*  /  -  +  C  Q)");
                        break;
                }
            } while (true);
        }
        private static decimal? StringToDecimal(string inputString)
        {
            var numberFortmatSeparatedByComa = new CultureInfo("en-US").NumberFormat;
            var numberFortmatSeparatedByDot = new CultureInfo("fr-CH").NumberFormat;

            if (!decimal.TryParse(inputString, NumberStyles.Any, numberFortmatSeparatedByComa, out decimal result))
            {
                if (!decimal.TryParse(inputString, NumberStyles.Any, numberFortmatSeparatedByDot, out result))
                {
                    return null;
                }

            }
            return result;
        }
    }
}
