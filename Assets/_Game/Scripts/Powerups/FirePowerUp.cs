using UnityEngine;

namespace LuisLabs.EvolutionGame.PowerUps
{
    [CreateAssetMenu(fileName = "power_up_fire_so", menuName = "PowerUps/Fire")]
    public class FirePowerUp : PowerUp
    {
        public override void Apply(GameObject target)
        {
            if (target.TryGetComponent(out IFireable fireable))
            {
                fireable.Fire();
            }
            else
            {
                Debug.LogError("The target does not have a IFireable component", this);
            }
        }
    }
}