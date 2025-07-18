using DungeonGame.Data.Core.Interfaces;

namespace DungeonGame.Data.Helpers;

public class DictionaryConverter : IDictionaryConverter
{
        public string ConvertDictionaryToString(Dictionary<string, int> dictionary)
    {
        // Convert Dictionary to a string (e.g., "Strength:18,Dexterity:15,Constitution:14")
        return string.Join(',', dictionary.Select(kv => $"{kv.Key}:{kv.Value}"));
    }

    public Dictionary<string, int> ConvertStringToDictionary(string value)
    {
        // Convert the string back to a Dictionary (splitting by commas and colons)
        return value.Split(',', StringSplitOptions.None)
                    .ToDictionary(s => s.Split(':', StringSplitOptions.None)[0],
                                  s => int.Parse(s.Split(':', StringSplitOptions.None)[1]));
    }
}