using LuisLabs.EvolutionGame.Common.Interfaces;
using UnityEngine;

namespace LuisLabs.EvolutionGame.Player
{
    public class PlayerController : MonoBehaviour, IRotatable, IFireable
    {
        [SerializeField] private GameObject fireParticle1;
        [SerializeField] private GameObject fireParticle2;
        [SerializeField] private GameObject fireParticle3;

        private float rotationSpeed = 0;
        private float numberOfParticles = 0;

        private void Update() 
        {
            float rotation = rotationSpeed * Time.deltaTime; transform.Rotate(Vector3.up, rotation);
            gameObject.transform.Rotate(Vector3.up, rotation);
        }

        public void Rotate(float angle)
        {
            rotationSpeed += angle;
        }

        public void Fire() 
        {
            numberOfParticles = Mathf.Clamp(numberOfParticles + 1, 1, 3);
            switch(numberOfParticles) {
                case 1:
                    fireParticle1.SetActive(true);
                    break;
                case 2:
                    fireParticle2.SetActive(true);
                    break;
                case 3:
                    fireParticle3.SetActive(true);
                    break;
            }
        }
    }
}