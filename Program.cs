using System;

namespace Calculatrice
{
    class Program
    {
        /*
         * Calculatrice :
         * 
         * Operations : + - * /
         * Flux simple : 
         * 1) Saisie de la partie gauche de l'expression --> 1
         * 2) Saisie de l'opérateur arithmétiques --> +
         * 3) Saisie de la partie droite de l'expression --> 3
         * 4) Affichage du resultat
         * 
         * Exigences : 
         * - La console s'éxecute tant que l'utilisateur ne saisie pas la lettre 'Q', 'Quitter' ou la combinaison de touches 'CTRL+Q'.
         * - Le dernier résultat est réutilisable et permet de sauter l'étape 1 du flux.
         * - Prévenir les erreurs de saisies.
         * - Commentaires, best practices, naming conventions, etc...
         * 
         * Thèmes :
         * - Boucles: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
         * - Tests et boolean: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
         * - Opérateur arithmétiques: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
         * - Value types: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
         * - Cast/Conversion de types: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression & https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
         * 
         */
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
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Entrez le nombre 2 : \n");
                    int num2 = int.Parse(Console.ReadLine());
                    int finala = num1 + num2;
                    Console.Write("votre résultat est : " + finala + "\n");
                    Console.Write("votre résultat est : " + finala + "\n");
                    Console.Write("votre résultat est : " + finala + "\n");
                    break;
                case "*":
                    /* Multiplication */
                    Console.Write("Entrez le nombre 1 : \n");
                    int num3 = int.Parse(Console.ReadLine());
                    Console.Write("Entrez le nombre 2 : \n");
                    int num4 = int.Parse(Console.ReadLine());
                    int finalm = num3 * num4;
                    Console.Write("votre résultat est : " + finalm + "\n");
                    Console.Write("votre résultat est : " + finalm + "\n");
                    Console.Write("votre résultat est : " + finalm + "\n");
                    break;
                case "-":
                    /* Soustraction */
                    Console.Write("Entrez le nombre 1 : \n");
                    int num5 = int.Parse(Console.ReadLine());
                    Console.Write("Entrez le nombre 2 : \n");
                    int num6 = int.Parse(Console.ReadLine());
                    int finals = num5 - num6;
                    Console.Write("votre résultat est : " + finals + "\n");
                    Console.Write("votre résultat est : " + finals + "\n");
                    Console.Write("votre résultat est : " + finals + "\n");
                    break;
                case "/":
                    /* Division */
                    Console.Write("Entrez le nombre 1 : \n");
                    int num7 = int.Parse(Console.ReadLine());
                    Console.Write("Entrez le nombre 2 : \n");
                    int num8 = int.Parse(Console.ReadLine());
                    int finald = num7 / num8;
                    Console.Write("votre résultat est : " + finald + "\n");
                    Console.Write("votre résultat est : " + finald + "\n");
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
