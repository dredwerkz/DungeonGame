using DungeonGame.GameCore.Models.Character;
using DungeonGame.GameCore.Models.Room;
using DungeonGame.GameCore.Helpers;
using DungeonGame.GameCore.Interfaces;

namespace DungeonGame.GameCore.Services;

public class TestGameStart()
{
    TestGameHelper _testGameHelper = new();

    public void StartGame()
    {
        var (charReginald, charSlash, roomTest) = _testGameHelper.ArrangeTestGame();
        Console.WriteLine(charReginald.Name);
    }
}