namespace LifeGame
{
    internal class Program
    {
        internal static void Main()
        {
            LifeGameInterface gameObject = new LifeGameInterface(40, 10);
            gameObject.StartGame();
        }
    }
}