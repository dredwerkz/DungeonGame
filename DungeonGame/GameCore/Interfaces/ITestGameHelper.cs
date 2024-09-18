using DungeonGame.GameCore.Models.Character;
using DungeonGame.GameCore.Models.Room;

namespace DungeonGame.GameCore.Interfaces;

public interface ITestGameHelper
{
public (Character, Character, Room) ArrangeTestGame();
}