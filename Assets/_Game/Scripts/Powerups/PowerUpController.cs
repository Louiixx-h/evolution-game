using System.Collections.Generic;

namespace LuisLabs.EvolutionGame.PowerUps 
{
    public class PowerUpController : IPowerUpController
    {
        private readonly List<PowerUpModel> powerUps = new List<PowerUpModel>();

        public void OnPowerUpCollected(PowerUp powerUp)
        {
            var foundPowerUp = powerUps.Find(p => p.Name == powerUp.Properties.name);
            
            if (foundPowerUp != null)
            {
                foundPowerUp.LevelUp();
                return;
            }

            var powerUpModel = PowerUpModel.CreatePowerUpModel(powerUp);
            powerUps.Add(powerUpModel);
        }

        public PowerUpModel GetPowerUpModel(string powerUpName)
        {
            return powerUps.Find(p => p.Name == powerUpName);
        }
    }
}