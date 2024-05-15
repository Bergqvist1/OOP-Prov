namespace OOP_Prov
{
    public class Player // klass för spelaren 
    {
        public int HP {get; set;} // skapa hp variabel

        public Player(int hp)
        {
            HP = hp;
        }

        public void Attackera()
        {
            Random Slump = new Random();
            int skada = Slump.Next(0, 10);
        }

        public void TaSkada(int skada)
        {
            HP -= skada;
        }

    }
}