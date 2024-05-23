using System;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using OOP_Prov;


class Program
{

    static void Main(string[] args)
    {

        List<OOP_Prov.Fiende> fiender;

        Spelare spelare = new Spelare(100, "Spelare", 1, 10);

        fiender = new List<Fiende>();
        {
            new Ork();
            new Wernow();
        }

        Console.Write(fiender.Count);
        int poäng = 0;

        bool SpelPÅ = true;

        while (spelare.HP > 0 && fiender[1].HP > 0 && SpelPÅ)
        {

            Console.WriteLine("Vem vill du strida mot?");
            Console.WriteLine("1: Strid mot en" + fiender[1].Typ);
            Console.WriteLine("2: Visa ditt och fienders  hp!");

            string val = Console.ReadLine();

            if(val == "1")
            {
                    spelare.Attackera(fiender[0]);
                    if(fiender[1].HP > 0 )
                    {
                        fiender[0].Attackera(spelare);
                        Console.WriteLine(fiender[1] + "slog tillbaks!");
                    }
            }
           
                    

            if(val == "2")
            {
                    Console.WriteLine("Du har" + spelare.HP);
                    Console.WriteLine(fiender[1].Typ + "har" + fiender[1].HP);
            }        
                    
            if(spelare.HP <= 0)
            {
                 Console.WriteLine("Du har stupit i strid");
                 poäng = 10;
                 SpelPÅ = false;
            }

            else if (fiender[1].HP <= 0)
            {
                Console.WriteLine("Du besegrade" + fiender[1].Typ + "! Du hade" + spelare.HP + "kvar");
                poäng = 50;

                fiender.RemoveAt(1);

                Console.WriteLine(fiender[1].Typ + "är besegrad, vill du fortsätta? (j/n)");
                string valForts = Console.ReadLine();

                if (valForts.ToLower() != "j")
                {
                    SpelPÅ = false;
                }
            }
        
        } 

        if (spelare.HP > 0 && fiender.Count <= 1)
        {
            Console.WriteLine("Du har besegrat alla dina fiender!");
        }

        Console.WriteLine("Dina poäng är" + poäng); // skriver ut poäng
        SparaPoäng(poäng); // spara 

    }


    static void SparaPoäng(int poäng)
    {
        StreamWriter sw = new StreamWriter("SparaPoäng.txt", true); // Väljer den fil som poängen ska sparas i
        sw.WriteLine("Ditt poäng är:" + poäng); // Skriver ut antalet poäng du har fått 
        sw.Close(); // stänger textfilen
    }
        
}
