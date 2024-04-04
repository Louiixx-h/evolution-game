using LuisLabs.EvolutionGame.Common.Interfaces;
using UnityEngine;

namespace LuisLabs.EvolutionGame.PowerUps {
    [CreateAssetMenu(fileName = "power_up_rotation_so", menuName = "PowerUps/Rotation")]
    public class RotationPowerUp : PowerUp
    {
        [SerializeField] private float rotationSpeed = 90f;

        public override void Apply(GameObject target)
        {
            if (target.TryGetComponent(out IRotatable rotatable))
            {
                rotatable.Rotate(rotationSpeed);
            }
            else
            {
                Debug.LogError("The target does not have a IRotatable component", this);
            }
        }
    } 
}