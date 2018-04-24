namespace LifeGame
{
    internal class Program
    {
        static internal void Main()
        {
            LifeGameInterface a = new LifeGameInterface(40, 10);
            a.StartGame();
        }
    }
}