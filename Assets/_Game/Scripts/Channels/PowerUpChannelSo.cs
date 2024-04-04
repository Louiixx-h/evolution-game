using System;
using LuisLabs.EvolutionGame.PowerUps;
using UnityEngine;

namespace LuisLabs.EvolutionGame.Channels {
    [CreateAssetMenu(fileName = "channel_power_up_So", menuName = "Channels/UiEvolutionChannelSo")]
    public class PowerUpChannelSo : ScriptableObject
    {
        public Action<PowerUp> OnPowerUpSelected;
        public Action<PowerUp> OnPowerUpCollected;

        public void NotifyPowerUpSelected(PowerUp powerUp)
        {
            OnPowerUpSelected?.Invoke(powerUp);
        }

        public void NotifyPowerUpCollected(PowerUp powerUp)
        {
            OnPowerUpCollected?.Invoke(powerUp);
        }
    }
}