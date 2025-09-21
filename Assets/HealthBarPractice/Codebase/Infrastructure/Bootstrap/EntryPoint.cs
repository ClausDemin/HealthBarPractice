using Assets.Codebase.GameLogic.Common.HealthBehavior;
using Assets.HealthBarPractice.Codebase.Common.HealthBehavior;
using Assets.HealthBarPractice.Codebase.Common.HealthBehavior.Presenter;
using Assets.HealthBarPractice.Codebase.Common.HealthBehavior.Presenter.Interface;
using Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View;
using Assets.HealthBarPractice.Codebase.Infrastructure.Configs;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.HealthBarPractice.Codebase.Infrastructure.Bootstrap
{
    public class EntryPoint: MonoBehaviour
    {
        private const string PlayerHealthDataPath = "Configs/Player/PlayerHealth";

        private readonly List<IHealthPresenter> _presenters = new();

        [SerializeField] private HealthComponent _playerHealth;
        [SerializeField] private HealthTextView _playerHealthText;
        [SerializeField] private HealthSliderView _healthSlider;
        [SerializeField] private SmoothHealthBar _smoothHealthBar;


        private void Awake()
        {
            _playerHealth.Init(LoadHealthData());
            CreatePresenters();
        }

        private HealthData LoadHealthData() 
        { 
            HealthConfig playerHealthConfig = Resources.Load<HealthConfig>(PlayerHealthDataPath);

            return new HealthData(playerHealthConfig.Max);
        }

        private void CreatePresenters() 
        {
            HealthPresenter textPresenter = new HealthPresenter(_playerHealthText, _playerHealth);
            HealthPresenter sliderPresenter = new HealthPresenter(_healthSlider, _playerHealth);
            HealthPresenter smoothSliderPresenter = new HealthPresenter(_smoothHealthBar, _playerHealth);

            _presenters.Add(textPresenter);
            _presenters.Add(sliderPresenter);
            _presenters.Add(smoothSliderPresenter);
        }
    }
}
