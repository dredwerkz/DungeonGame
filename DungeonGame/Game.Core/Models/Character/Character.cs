namespace DungeonGame.Game.Core.Models.Character;
public class PlayerCharacter
{
    public string Name { get; set; } = null!;
    public string PlayerClass { get; set; } = null!;
    public int Level { get; set; }
    public StatBlock StatBlock {get;set;} = null!;
    public int Initiative { get; set; }
}