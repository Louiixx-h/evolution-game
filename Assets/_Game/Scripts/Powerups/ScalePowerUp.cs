using UnityEngine;

namespace LuisLabs.EvolutionGame.PowerUps
{
    [CreateAssetMenu(fileName = "power_up_scale_so", menuName = "PowerUps/Scale")]
    public class ScalePowerUp : PowerUp
    {
        [SerializeField] private float scaleMultiplier = 2f;

        public override void Apply(GameObject target)
        {
            if (target.TryGetComponent(out Transform transform))
            {
                transform.localScale *= scaleMultiplier;
            }
            else
            {
                Debug.LogError("The target does not have a Transform component", this);
            }
        }
    }
}