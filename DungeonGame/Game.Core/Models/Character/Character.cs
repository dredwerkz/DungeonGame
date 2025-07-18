namespace DungeonGame.Game.Core.Models.Character;
public class PlayerCharacter
{
    public string Name { get; set; } = null!;
    public string PlayerClass { get; set; } = null!;
    public int Level { get; set; }
    public Dictionary<string, int> Attributes { get; set; } = new Dictionary<string, int>();
    public int Initiative { get; set; }
}