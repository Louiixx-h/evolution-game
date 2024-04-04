using LuisLabs.EvolutionGame.Channels;
using LuisLabs.EvolutionGame.PowerUps;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace LuisLabs.EvolutionGame.UI {
    public class UIEvolutionView : MonoBehaviour
    {
        [SerializeField] private PowerUp button1PowerUp;
        [SerializeField] private PowerUp button2PowerUp;
        [SerializeField] private PowerUp button3PowerUp;
        [SerializeField] private Button button1;
        [SerializeField] private Button button2;
        [SerializeField] private Button button3;
        [SerializeField] private PowerUpChannelSo evolutionChannel;

        private void Start()
        {
            button1.onClick.AddListener(OnButton1Click);
            button2.onClick.AddListener(OnButton2Click);
            button3.onClick.AddListener(OnButton3Click);
        }

        private void OnButton1Click()
        {
            evolutionChannel.NotifyPowerUpSelected(button1PowerUp);
        }

        private void OnButton2Click()
        {
            evolutionChannel.NotifyPowerUpSelected(button2PowerUp);
        }

        private void OnButton3Click()
        {
            evolutionChannel.NotifyPowerUpSelected(button3PowerUp);
        }
    }
}