using LuisLabs.EvolutionGame.CoreDi;

namespace LuisLabs.EvolutionGame.PowerUps 
{
    public interface IPowerUpController
    {
        public void OnPowerUpCollected(PowerUp powerUp);
        public PowerUpModel GetPowerUpModel(string powerUpName);
    }
}