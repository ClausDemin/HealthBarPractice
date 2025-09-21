using Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View.Interface;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View
{
    [RequireComponent(typeof(Slider))]
    public class SmoothHealthBar : MonoBehaviour, IHealthView
    {
        [SerializeField] private float _changeDuration;
        
        private Slider _healthBar;

        private Coroutine _animation;

        private void Awake()
        {
            _healthBar = GetComponent<Slider>();
        }

        public void Init(int current, int max)
        {
            _healthBar.maxValue = max;
            _healthBar.value = current;

            _healthBar.wholeNumbers = false;
        }

        public void UpdateView(int current, int max)
        {
            if (_healthBar.maxValue != max)
            {
                _healthBar.maxValue = max;
            }

            PlayChangeAnimation(current);

        }

        private void PlayChangeAnimation(int current)
        {
            if (isActiveAndEnabled)
            {
                if (_animation != null) 
                {
                    StopCoroutine(_animation);
                }

                _animation = StartCoroutine(ChangeValue(current));
            }
        }

        private IEnumerator ChangeValue(int target) 
        { 
            float changeStep = Mathf.Abs((_healthBar.value - target) / (_changeDuration/Time.deltaTime));

            while (_healthBar.value != target) 
            { 
                _healthBar.value = Mathf.MoveTowards(_healthBar.value, target, changeStep);

                yield return null;
            }

            _animation = null;
            yield break;
        }
    }
}
