using DungeonGame.Game.Core.Models.Character;

namespace DungeonGame.Game.Core.Models.Room;

public class Room
{
    public string Name { get; set; } = null!;
    public RoomDimensions RoomDimensions { get; set; } = null!;
    public List<PlayerCharacter> Characters {get;set;} = null!;
}