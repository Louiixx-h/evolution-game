using LuisLabs.EvolutionGame.Channels;
using LuisLabs.EvolutionGame.CoreDi;
using LuisLabs.EvolutionGame.PowerUps;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LuisLabs.EvolutionGame.UI {
    public class UICardEvolutionView : MonoBehaviour
    {
        [SerializeField] private PowerUpChannelSo evolutionChannel;
        [SerializeField] private GameObject cardGO;
        [SerializeField] private Button button;
        [SerializeField] private TextMeshProUGUI title;
        [SerializeField] private TextMeshProUGUI description;
        [SerializeField] private TextMeshProUGUI level;

        private PowerUpModel powerUpModel;
        private PowerUp powerUp;
        private IPowerUpController powerUpController;

        private void Awake() 
        {
            evolutionChannel.OnPowerUpSelected += OnPowerUpSelected;
            button.onClick.AddListener(OnButtonClick);
        }

        private void Start() 
        {
            powerUpController = ServiceLocator.Current.Get<IPowerUpController>();
        }

        private void OnDestroy() 
        {
            evolutionChannel.OnPowerUpSelected -= OnPowerUpSelected;
            button.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            Time.timeScale = 1;
            evolutionChannel.NotifyPowerUpCollected(powerUp);
            cardGO.SetActive(false);
            ClearView();
        }

        private void OnPowerUpSelected(PowerUp powerUp)
        {
            Time.timeScale = 0;
            this.powerUp = powerUp;
            powerUpController.OnPowerUpCollected(powerUp);
            powerUpModel = powerUpController.GetPowerUpModel(powerUp.Properties.name);
            cardGO.SetActive(true);
            SetupView();
        }

        public void SetupView() 
        {
            title.text = powerUpModel.Name;
            level.text = powerUpModel.Level.ToString();
            description.text = $"{powerUpModel.GetDescriptionByLevel(powerUpModel.Level)}";
        }

        public void ClearView() 
        {
            title.text = string.Empty;
            description.text = string.Empty;
            level.text = string.Empty;
        }
    }
}