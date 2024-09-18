using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Helpers;
using Microsoft.Extensions.Logging;

namespace DungeonGame.Game.Services;

public class TestGameStart(ILogger<TestGameStart> logger, ITestGameHelper testGameHelper) : ITestGameStart
{
    //private readonly TestGameHelper _testGameHelper = new();

    public void StartGame()
    {
        var (charReginald, charSlash, roomTest) = testGameHelper.ArrangeTestGame();
        logger.LogInformation("Log Enabled!");
        Console.WriteLine(charReginald.Name);
    }
}