using DungeonGame.Game.Core.Models.Character;
using DungeonGame.Game.Core.Models.Room;

namespace DungeonGame.Game.Core.Interfaces;

public interface ITestGameHelper
{
    public (PlayerCharacter, PlayerCharacter, Room) ArrangeTestGame();
}