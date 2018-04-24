namespace LifeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LifeGameInterface a = new LifeGameInterface(40, 10);
            a.StartGame();
        }
    }
}
