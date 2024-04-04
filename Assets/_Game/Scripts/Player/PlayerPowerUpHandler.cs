using LuisLabs.EvolutionGame.Channels;
using LuisLabs.EvolutionGame.PowerUps;
using UnityEngine;

namespace LuisLabs.EvolutionGame.Player {
    public class PlayerPowerUpHandler : MonoBehaviour
    {
        [SerializeField] private PowerUpChannelSo powerUpChannel;
        [SerializeField] private GameObject playerGO;

        private void OnEnable()
        {
            powerUpChannel.OnPowerUpCollected += OnPowerUpCollected;
        }

        private void OnDisable()
        {
            powerUpChannel.OnPowerUpCollected -= OnPowerUpCollected;
        }

        private void OnPowerUpCollected(PowerUp powerUp)
        {
            powerUp.Apply(playerGO);
        }
    }
}