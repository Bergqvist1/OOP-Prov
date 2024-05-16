using System;


class program
{

    static void SparaPoäng(int poäng)
    {
        StreamWriter sw = new StreamWriter("poäng.txt", true);
        sw.WriteLine("Spelarens poäng är" + poäng);
    }
    public static void Main(string[] args)
    {
        Spelare spelare = new Spelare(100);
        Fiende fiende1 = new Fiende("Orc", 45);
        Fiende fiende2 = new Fiende("Blatte", 35);

    	while (spelare.HP > 0 && (fiende1.HP) > 0 || fiende2.HP > 0 )
        {
            Console.WriteLine("Du har" + spelare.HP + "HP");
            Console.WriteLine("Fiende 1 är " + fiende1.Typ + "och har" + fiende1.HP);
            Console.WriteLine("Fiende 2 är " + fiende2.Typ + "och har" + fiende2.HP);
            Console.WriteLine("Vem vill du strida mot?");
            Console.WriteLine("1: Strida mot en" + fiende1.Typ);
            Console.WriteLine("2: Strid mot en" + fiende2.Typ);

            int val = int.Parse(Console.ReadLine();)

            switch(val)
            {
                case 1:
                    spelare.Attack(fiende1);
                    if(fiende1 > 0 )
                    {
                        fiende1.Attackera(spelare)
                        Console.WriteLine(fiende1.Typ + "slog tillbaks!");
                    }
                    break;

                case 2:
                    spelare.Attackera(fiende2);
                    if(fiende2.HP > 0)
                    {
                        fiende2.Attackera(spelare);
                        Console.WriteLine(fiende2.Typ + "slog tillbaka!");
                    }

                
                default:
                    Console.WriteLine("Välj ett giltigt alternativ");
                    break; 
            }

            if(spelare.HP <= 0)
            {
                Console.WriteLine("Striden är över, DU STUPADE I KRIG!");
            }

            else
            {
                Console.WriteLine("Du stred tappert och vann!");
            }

            SparaPoäng(spelare.HP);
        }
    }
}
