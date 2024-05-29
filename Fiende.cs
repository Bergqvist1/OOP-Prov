using System;
using System.IO;
using OOP_Prov;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Prov
{

    public class Fiende: Hjälte // bas klassen för fiender som ärver av klassen Hjälte 
    {
        public Fiende(int hp, string typ, int Minstskada, int MestSkada): base(hp, typ, Minstskada, MestSkada){} // Gör så att fienden kan sätta hp, typ, MinstSkada och MestSkada
    }    






}
