using System;

namespace OOP_Prov
{
    public class Fiende
    {
        private string Typ { get; set; }
        private int HP { get; set; }

        private Fiende(string typ, int hp)
        {
            Typ = typ;
            HP = hp;
        }

        public void Attackera(Spelare spelare)
        {
            Random SlumpF = new Random();
            int skada = SlumpF.Next(3,8);
            spelare.TaSkada(skada);
        }

        public void TaSkada(int skada)
        {
            HP -= skada;
            
            if(HP <= 0)
            {
                Console.WriteLine("Din tappra stridsinsatts har besegrat fienden!");
            }
        }

        
    }
}