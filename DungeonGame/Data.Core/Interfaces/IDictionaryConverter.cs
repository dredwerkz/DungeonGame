namespace DungeonGame.Data.Core.Interfaces;

public interface IDictionaryConverter
{
    public string ConvertDictionaryToString(Dictionary<string, int> dictionary);
    public Dictionary<string, int> ConvertStringToDictionary(string value);
}