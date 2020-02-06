using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci i gradi?");
            int gradi = int.Parse(Console.ReadLine());
            if(gradi<=360)
            {
                Console.WriteLine("inserisci i primi?");
                int primi = int.Parse(Console.ReadLine());
                if (primi <= 59)
                {
                    Console.WriteLine("inserisci i secondi?");
                    double secondi = double.Parse(Console.ReadLine());
                    if (secondi <= 60)
                    {
                        double ampiezza = (gradi * 60 * 60) + (primi * 60) + secondi;
                        Console.WriteLine($"l'ampiezza è {ampiezza} secondi");
                    }

                    
                }else if(gradi>360)
                {
                    Console.WriteLine("inserisci i gradi?");
                    int gradi1 = int.Parse(Console.ReadLine());
                    if (gradi1 <= 360)
                    {
                        Console.WriteLine("inserisci i primi?");
                        int primi1 = int.Parse(Console.ReadLine());
                        if (primi1 <= 59)
                        {
                            Console.WriteLine("inserisci i secondi?");
                            double secondi1 = double.Parse(Console.ReadLine());
                            if (secondi1 <= 60)
                            {
                                double ampiezza = (gradi1 * 60 * 60) + (primi1 * 60) + secondi1;
                                Console.WriteLine($"l'ampiezza è {ampiezza} secondi");
                            }

                        }

                    }
                }
            Console.ReadLine();
        }
    }
}
