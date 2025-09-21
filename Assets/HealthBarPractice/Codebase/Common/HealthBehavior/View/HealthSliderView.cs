using Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View.Interface;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.Common.HealthBehavior
{
    [RequireComponent(typeof(Slider))]
    public class HealthSliderView: MonoBehaviour, IHealthView
    {
        private Slider _healthBar;

        private void Awake()
        {
            _healthBar = GetComponent<Slider>();
        }

        public void Init(int current, int max) 
        {
            _healthBar.maxValue = max;
            _healthBar.value = current;
        }

        public void UpdateView(int current, int max)
        {
            if (_healthBar.maxValue != max) 
            {
                _healthBar.maxValue = max;
            }

            _healthBar.value = current;
        }
    }
}
