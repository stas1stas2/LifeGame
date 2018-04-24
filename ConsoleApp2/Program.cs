namespace LifeGame
{
    internal class Program
    {
        static internal void Main()
        {
            LifeGameInterface GameObject = new LifeGameInterface(40, 10);
            GameObject.StartGame();
        }
    }
}