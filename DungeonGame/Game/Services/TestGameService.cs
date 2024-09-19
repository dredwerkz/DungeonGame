using DungeonGame.Game.Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace DungeonGame.Game.Services;

public class TestGameService(
ILogger<TestGameService> logger,
ITestGameHelper testGameHelper,
IDiceService diceService,
ICharacterService characterService) : ITestGameService
{
    public void StartGame()
    {
        characterService.GenerateCharacter();
    }
}