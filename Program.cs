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

        List<OOP_Prov.Fiende> fiender; // en lsita för fiender som finns

        Spelare spelare = new Spelare(100, "Spelare", 1, 10); // skapar själva spelaren

        fiender = new List<Fiende>(); // Skapar en lista för fiender
        {
            new Ork(); // skapar fienden Ork som också finns i listan
            new Wernow(); // Skapar fienden Wernow som också finns i listan 
        }

        Console.Write(fiender.Count); // Skriver ut antalet fiender som finns i listan
        int poäng = 0; // sätter att poängen är = 0 i början 

        bool SpelPÅ = true; // Bool variabel för att se så att spelet är igång 

        while (spelare.HP > 0 && fiender[1].HP > 0 && SpelPÅ) // Så länge Spelaren och fiende 1 lever & bool är på true gäller själva loopen
        {

            Console.WriteLine("Vem vill du strida mot?"); // Skriver ut valen som spelaren har 
            Console.WriteLine("1: Strid mot en" + fiender[1].Typ); // Alternativ 1 för att attackera fiende 1
            Console.WriteLine("2: Visa ditt och fienders  hp!"); // Alternativ 2 för att skriva ut ditt och fiendes hp

            string val = Console.ReadLine(); // Läser av om man skriver 1 eller 2 

            if(val == "1") // när man skriver/väljer  1 
            {
                    spelare.Attackera(fiender[1]); // spelaren attackerar fiende 1
                    if(fiender[1].HP > 0 ) // Om fienden har mer än 0 hp så händer följande
                    {
                        fiender[1].Attackera(spelare); // fiende 1 attackerar tillbaks på spelaren
                        Console.WriteLine(fiender[1] + "slog tillbaks!"); // Skriver ut att fiende 1 slår tillbaks på spelaren
                    }
            }
           
                    

            if(val == "2") // När man skriver/väljer 2
            {
                    Console.WriteLine("Du har" + spelare.HP); // Skriver ut spelarens HP
                    Console.WriteLine(fiender[1].Typ + "har" + fiender[1].HP); // Skriver ut fiendens typ och hur mycket hp den har.
            }        
                    
            if(spelare.HP <= 0) // Om spelarens hp är under 0 eller = 0 händer följande
            {
                 Console.WriteLine("Du har stupit i strid"); // Skriver ut att spelaren har stupit i strid, alltså att spelaren har dött
                 poäng = 10; // Ger spelaren 10 poäng för sitt tappra mod.
                 SpelPÅ = false; // Sätter spelet på false då du inte kan spela med en död hjälte
            }

            else if (fiender[1].HP <= 0) // Om spelaren dödar fienden så dess hp är under 0 eller = 0 händer följande
            {
                Console.WriteLine("Du besegrade" + fiender[1].Typ + "! Du hade" + spelare.HP + "kvar");  // Skriver ut att spelaren besegrade fienden och mängden hp som spelaren hade kvar
                poäng = 50; // ger spelaren 50 poäng för sin tappra strid mot fienden

                fiender.RemoveAt(1); // Tar bort fienden som besegrats för att man inte kan attackera en död fiende

                Console.WriteLine(fiender[1].Typ + "är besegrad, vill du fortsätta? (j/n)"); // Skriver ut att fienden är besegrad och frågar spelaren om den vill fortsätta spela
                string valForts = Console.ReadLine(); // Läser av vad spelaren väljer 

                if (valForts.ToLower() != "j") // Om spelarens val inte är = j händer följande
                {
                    SpelPÅ = false; // loopen avslutats
                }
            }
        
        } 

        if (spelare.HP > 0 && fiender[1].HP < 0) // Om spelaren är vid liv och fiender är döda händer följande
        {
            Console.WriteLine("Du har besegrat alla dina fiender!"); // Skriver ut att du har besegrat alla fiender
        }

        Console.WriteLine("Dina poäng är" + poäng); // skriver ut spelarens poäng
        SparaPoäng(poäng); // sparar seplarens poäng 

    }


    static void SparaPoäng(int poäng) // Gör så att man lägger upp poängen i en text fil 
    {
        StreamWriter sw = new StreamWriter("SparaPoäng.txt", true); // Väljer den fil som poängen ska sparas i
        sw.WriteLine("Ditt poäng är:" + poäng); // Skriver ut antalet poäng spelaren har fått 
        sw.Close(); // stänger textfilen
    }
        
}
