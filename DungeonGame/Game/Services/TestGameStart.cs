using DungeonGame.Game.Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace DungeonGame.Game.Services;

public class TestGameStart(
ILogger<TestGameStart> logger,
ITestGameHelper testGameHelper
) : ITestGameStart
{
    public void StartGame()
    {
        var (charReginald, charSlash, roomTest) = testGameHelper.ArrangeTestGame();
        logger.LogInformation("Log Enabled!");
        Console.WriteLine(charReginald.Name);
    }
}