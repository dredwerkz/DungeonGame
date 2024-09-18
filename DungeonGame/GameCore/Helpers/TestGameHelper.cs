using DungeonGame.GameCore.Interfaces;
using DungeonGame.GameCore.Models.Character;
using DungeonGame.GameCore.Models.Room;

namespace DungeonGame.GameCore.Helpers;

public class TestGameHelper(): ITestGameHelper
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