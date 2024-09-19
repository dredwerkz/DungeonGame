using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Core.Models.Character;
using DungeonGame.Game.Core.Models.Room;

namespace DungeonGame.Game.Helpers;

public class TestGameHelper : ITestGameHelper
{
    public (PlayerCharacter, PlayerCharacter, Room) ArrangeTestGame()
    {
        var charReginald = new PlayerCharacter()
        {
            Name = "Reginald",
            Class = "Fighter",
            Level = 1
        };

        var charSlash = new PlayerCharacter()
        {
            Name = "Slash",
            Class = "Rogue",
            Level = 1
        };

        var roomTest = new Room()
        {
            Name = "Test Room",
            RoomDimensions = new RoomDimensions()
            {
                DimensionX = 5,
                DimensionY = 5
            }
        };

        return (charReginald, charSlash, roomTest);
    }
}