using System;
using System.Dynamic;
using System.IO;
using OOP_Prov;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Prov
{

    public class Hjälte // namn på klass
    {
     public int HP {get; set;} // hjältens namn

     public string Typ{get; set;} // hjältens typ

     public int MinstSkada{get; set;} //  hjältens minsta skada som den kan göra

     public int MestSkada{get; set;} //  hjältens mest skada som den kan göra

     Random slump = new Random(); // Skapar en Random som heter slump för att senare kunna användas vid Skada 


       public Hjälte(int hp, string typ, int Minstskada, int Mestskada) // konstruktor för att initiera hjälten o
        {
           HP = hp; // sätter själva hp:t på Hjälten
           Typ = typ; // sätter hjältens typ
           MinstSkada = Minstskada; // sätter hjältens insta skada som den kan göra
           MestSkada = Mestskada; // sätter hjältens mest skada som den kan göra
        }

        public virtual void Attackera(Hjälte fiende) // Metod för att hjälte ska kunna attackera och göra skada på en fiende 
        {
            int skada = slump.Next(MinstSkada, MestSkada + 2); // Gör så att skadan är en slump mellan minst och mest skada +2
            Console.WriteLine("Du Svingade ditt svärd och gjorde" + skada + "skada på" + fiende.Typ); // skriver mängden skada och på vilken fiende som tog skadan
            fiende.HP -= skada; // Gör så att fiendens hp ändras -= skadan.

            if(fiende.HP < 0 ) // När fiendes hp är under 0 så sätts livet till 0
            {
                fiende.HP = 0; // Om fiendes liv är 0 blir det 0, fienden är död
            }
        }

    }
}
