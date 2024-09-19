using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Core.Models.Character;

namespace DungeonGame.Game.Services.Character;

public class CharacterService(ICharacterHelper characterHelper) : ICharacterService
{
    public PlayerCharacter GenerateCharacter()
    {
        var newCharacter = new PlayerCharacter()
        {
        };

        characterHelper.RollBaseStatBlock();

        return newCharacter;
    }
}