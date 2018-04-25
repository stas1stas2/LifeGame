namespace LifeGame
{
    internal class Program
    {
        static internal void Main()
        {
            LifeGameInterface gameObject = new LifeGameInterface(40, 10);
            gameObject.StartGame();
        }
    }
}