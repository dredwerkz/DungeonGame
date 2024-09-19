using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Core.Models.Room;
using Microsoft.Extensions.Logging;

namespace DungeonGame.Game.Services;

public class TestGameStart(
ILogger<TestGameStart> logger,
ITestGameHelper testGameHelper) : ITestGameStart
{
    public void StartGame()
    {
        var (charReginald, charSlash, roomTest) = testGameHelper.ArrangeTestGame();

        logger.LogInformation("Log Enabled!");
        Console.WriteLine(charReginald.Name);

        List<Room> availableRooms = [roomTest];

        availableRooms[0].Characters = [];

        availableRooms[0].Characters.Add(charReginald);
        availableRooms[0].Characters.Add(charSlash);

        foreach (var character in availableRooms[0].Characters)
        {
            var rnd = new Random();
            character.Initiative = rnd.Next(20);
        }

        var testRoomChars = availableRooms[0].Characters;

        logger.LogInformation($"{testRoomChars[0].Name}'s initiative is: {testRoomChars[0].Initiative}");
        logger.LogInformation($"{testRoomChars[1].Name}'s initiative is: {testRoomChars[1].Initiative}");

    }
}