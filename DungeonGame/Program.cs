using DungeonGame.GameCore.Services;

namespace DungeonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var testGameStart = new TestGameStart();
          testGameStart.StartGame();
        }
    }
}
