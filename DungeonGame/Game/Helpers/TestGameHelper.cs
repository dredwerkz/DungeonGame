using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Core.Models.Character;
using DungeonGame.Game.Core.Models.Room;

namespace DungeonGame.Game.Helpers;

public class TestGameHelper : ITestGameHelper
{
    public (Character, Character, Room) ArrangeTestGame()
    {
        var charReginald = new Character()
        {
            Name = "Reginald",
            Class = "Fighter",
            Level = 1
        };

        var charSlash = new Character()
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