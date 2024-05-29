using System;
using System.IO;
using OOP_Prov;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Prov
{
    public class Spelare: Hjälte // klass för spelaren 
    {
       public Spelare(int hp, string typ, int Minstskada, int MestSkada): base(hp, typ, Minstskada, MestSkada){} // sätter spelarens info utifrån Hjälte klassen
    }
}
