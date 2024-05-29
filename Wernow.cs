using System;
using System.IO;
using OOP_Prov;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Prov
{
    
    public class Wernow: Fiende // Skapar fiende klasen Wernow som ärver av Fiende
    {
        public Wernow(): base(60, "Wernow", 4,15){}  // sätter fiende klassen Wernows info utifån fiende. Alltså sätter hp, typ, minst skada, mest skada
    }
}



