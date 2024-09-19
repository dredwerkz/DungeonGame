using System.Reflection.Metadata;
using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Core.Models.Character;

namespace DungeonGame.Game.Services.Character;

public class CharacterHelper(IDiceService diceService) : ICharacterHelper
{
    public StatBlock RollBaseStatBlock()
    {
        StatBlock statBlock = new()
        {
            Attributes = []
        };

        List<int> freeValues = [];

        for (int i = 0; i < 7; i++)
        {
            var result = diceService.GetRoll(4, 6);
            result.Results.Sort();

            //Console.WriteLine($"Original total was: {result.Total}, dropping lowest roll ({result.Results[0]} for {result.Total - result.Results[0]})");

            result.Total -= result.Results[0];

            freeValues.Add(result.Total);
        };

        freeValues = [.. freeValues.OrderByDescending(c => c)];

        // TODO: Make a class containing one of these for every class and reference it in this helper.
        List<string> attPriority = ["STR", "CON", "DEX", "CHA", "LCK", "INT", "WIS"];

        for (int i = 0; i < 7; i++)
        {
            statBlock.Attributes.Add(attPriority[i], freeValues[i]);
        }

        // Need to make this a const at some point in the future
        List<string> order = ["STR", "DEX", "CON", "INT", "WIS", "CHA", "LCK"];

        // Debug
        foreach (var key in order)
        {
            Console.WriteLine($"{key}: {statBlock.Attributes[key]}");
        }

        return statBlock;
    }             
}