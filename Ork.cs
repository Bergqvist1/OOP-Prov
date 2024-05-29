using System;
using System.IO;
using OOP_Prov;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Prov
{
    public class Ork: Fiende // skapar klasen Ork som ärver av klassen Fiende 
    {
        public Ork(): base(37, "Ork", 1,11){} // Sätter Orkens info utifrån fienden klassen
    }
}
