using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableauEntier = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Console.WriteLine(" Voici un tableau d'entier: \n");

            foreach(int entier in tableauEntier)
            {
                Console.WriteLine("   " + entier);
            }
            
            Console.Write("\n Choisir la limite maximale des valeurs à garder: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------\n");

            int[] valeurMaxTableauEntier = tableauEntier.Where((x) => x <= n).ToArray();
            double average = (double)valeurMaxTableauEntier.Average();

            Console.WriteLine(" Le nouveau tableau d'entier est: \n");

            foreach (int entier in valeurMaxTableauEntier)
            {
                Console.WriteLine("   " + entier);
            }

            Console.Write("\n La moyenne de ce nouveau tableau = " + average);

            Console.ReadLine();
        }
    }
}
