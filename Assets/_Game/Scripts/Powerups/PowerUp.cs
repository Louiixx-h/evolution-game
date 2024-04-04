using UnityEngine;

namespace LuisLabs.EvolutionGame.PowerUps {
    public abstract class PowerUp : ScriptableObject
    {
        public PowerUpProperties Properties;
        public abstract void Apply(GameObject target);
    }
}