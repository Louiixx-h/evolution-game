using LuisLabs.EvolutionGame.PowerUps;
using UnityEngine;

namespace LuisLabs.EvolutionGame.CoreDi 
{
    public static class DiBootstrapper
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void Initiailze()
        {
            ServiceLocator.Initiailze();
            ServiceLocator.Current.Register<IPowerUpController>(new PowerUpController());
        }
    }
}