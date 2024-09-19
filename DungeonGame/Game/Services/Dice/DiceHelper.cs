using DungeonGame.Game.Core.Interfaces;

namespace DungeonGame.Game.Services.Dice;

public class DiceHelper() : IDiceHelper
{
    public int Roll(int dice)
    {
        var rnd = new Random();

        return rnd.Next(dice) + 1;
    }
}