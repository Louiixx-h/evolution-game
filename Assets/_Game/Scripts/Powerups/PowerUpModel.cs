using System.Collections.Generic;
using LuisLabs.EvolutionGame.PowerUps;

public class PowerUpModel
{
    public string Name { get; set; }
    public int Level { get; set; }
    public Dictionary<int, string> EvolutionDescriptions { get; set; }

    public PowerUpModel(string name, Dictionary<int, string> evolutionDescriptions)
    {
        Name = name;
        Level = 1;
        EvolutionDescriptions = evolutionDescriptions;
    }

    public void LevelUp()
    {
        Level++;
    }

    public string GetDescriptionByLevel(int level)
    {
        if (EvolutionDescriptions.ContainsKey(level))
        {
            return EvolutionDescriptions[level];
        }
        else
        {
            return "No description available for this level.";
        }
    }

    public static PowerUpModel CreatePowerUpModel(PowerUp powerUp)
    {
        var properties = powerUp.Properties;
        var dictionary = new Dictionary<int, string>();
        for (int i = 0; i < properties.evolutionDescriptions.Length; i++)
        {
            dictionary.Add(i + 1, properties.evolutionDescriptions[i]);
        }
        return new PowerUpModel(properties.name, dictionary);
    }
}