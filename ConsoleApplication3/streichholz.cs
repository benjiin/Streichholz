using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Bitte geben Sie Ihre Anzahl an Spielern an");
            int person = Convert.ToInt32(Console.ReadLine());
            int zufall = rnd.Next(0, person);
            int[] nummer = new int[person];
            bool[] isUsedId = new bool[person];

            bool spiel = true;
            int runden = person;
            int loser = 0;
            while (spiel)
            {
                for(int j=0; j<person; j++)
                {

                    Console.WriteLine("Gezeigt werden die Streichhölzer \"nebeneinanderliegend\" wobei das Streichholz mit der 1 das kurze ist");
                    nummer[zufall] = 1;
                    for (int i = 0; i < nummer.Length; i++)
                    {
                        if (isUsedId[i] == false)
                        {
                            Console.WriteLine("Streichholz {0}: hat den Wert {1}", i+1 , nummer[i]);
                        }
                    }
                    Console.WriteLine("Spieler {0} Bitte ziehen Sie ein Streichholz. (Nummer zwischen 1-{1} eingeben)", j+1, person);
                    int auswahl = Convert.ToInt32(Console.ReadLine())-1;

                    isUsedId[auswahl] = true;

                    if (auswahl == zufall)
                    {
                        loser = j+1;                        
                    }
                    runden -= 1;
                }           
                if (runden == 0)
                {
                    spiel = false;
                }
                Console.WriteLine("Spieler {0} hat das Spiel verloren",loser);
            }
        }   
    }
}
