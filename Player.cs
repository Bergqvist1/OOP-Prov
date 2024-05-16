using System;

namespace OOP_Prov
{
    public class Spelare // klass för spelaren 
    {
        private int HP {get; set;} // skapa hp variabel

        private Spelare(int hp)
        {
            HP = hp;
        }

        public void Attackera(Fiende fiende)
        {
            Random SlumpS = new Random();
            int skada = SlumpS.Next(0, 10);
            fiende.TaSkada(skada);
            Console.WriteLine("Du Svingade ditt svärd och gjorde" + skada + "skada på fienden");
        }

        public void TaSkada(int skada)
        {
            HP -= skada;

            Console.WriteLine("Fienden slog till dig och gjorde" + skada + "skada på dig");

            if(HP <= 0)
            {
                Console.WriteLine("Fienden körde ett svärd genom din skalle, du förlorade");
            }
        }

    }
}