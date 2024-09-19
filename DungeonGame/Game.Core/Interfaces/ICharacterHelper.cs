using DungeonGame.Game.Core.Models.Character;

namespace DungeonGame.Game.Core.Interfaces;

public interface ICharacterHelper
{
    public StatBlock RollBaseStatBlock();
}