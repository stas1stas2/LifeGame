namespace LifeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Universe.LifeGameInterface a = new Universe.LifeGameInterface(40, 10);
            a.StartGame();
        }
    }
}
