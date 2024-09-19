namespace DungeonGame.Game.Core.Models.Character;
public class PlayerCharacter
{
    public string Name { get; set; } = null!;
    public string Class { get; set; } = null!;
    public int Level { get; set; }
    public int Initiative { get; set; }
}