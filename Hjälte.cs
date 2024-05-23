using System;
using System.Dynamic;
using System.IO;
using OOP_Prov;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Prov
{

    public class Hjälte 
    {
     public int HP {get; set;}

     public string Typ{get; set;}

     public int MinstSkada{get; set;}

     public int MestSkada{get; set;}

     Random slump = new Random();


       public Hjälte(int hp, string typ, int Minstskada, int Mestskada)
        {
           HP = hp;
           Typ = typ;
           MinstSkada = Minstskada;
           MestSkada = Mestskada;
        }

        public virtual void Attackera(Hjälte fiende)
        {
            int skada = slump.Next(MinstSkada, MestSkada + 2);
            Console.WriteLine("Du Svingade ditt svärd och gjorde" + skada + "skada på" + fiende.Typ);
            fiende.HP -= skada;

            if(fiende.HP < 0 )
            {
                fiende.HP = 0;
            }
        }

    }
}