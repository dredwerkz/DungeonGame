using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Core.Models.Dice;

namespace DungeonGame.Game.Services.Dice;

public class DiceService(IDiceHelper diceHelper) : IDiceService
{
    public RollResult GetRoll(int count, int dice)
    {
        RollResult result = new();
        List<int> rollResults = [];

        while (count > 0)
        {
            var roll = diceHelper.Roll(dice);
            //Console.WriteLine($"Count is: {count} - Roll is {roll}");

            rollResults.Add(roll);
            result.Total += roll;
            
            count--;
        }

        result.Results = rollResults;

        return result;
    }
}