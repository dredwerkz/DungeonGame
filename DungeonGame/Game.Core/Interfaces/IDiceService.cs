using DungeonGame.Game.Core.Models.Dice;

namespace DungeonGame.Game.Core.Interfaces;

public interface IDiceService
{
    public RollResult GetRoll(int count, int dice);
}