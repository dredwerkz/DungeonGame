using System.Reflection;
using System.Text.Json.Serialization;

namespace DungeonGame.Game.Core.Models.Character;

public class StatBlock
{
    public Dictionary<string, int> Attributes {get;set;} = null!;

}