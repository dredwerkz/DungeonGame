using DungeonGame.Game.Core.Models.Character;

namespace DungeonGame.Game.Core.Interfaces;

public interface ICharacterService
{
    public PlayerCharacter GenerateCharacter();
}