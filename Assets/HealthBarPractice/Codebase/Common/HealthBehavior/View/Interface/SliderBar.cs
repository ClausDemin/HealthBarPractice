using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View.Interface
{
    [RequireComponent(typeof(Slider))]
    public abstract class SliderBar : MonoBehaviour, IHealthView
    {
        protected Slider _Bar;

        private void Awake()
        {
            _Bar = GetComponent<Slider>();
        }

        public void Init(int current, int max)
        {
            _Bar.maxValue = max;
            _Bar.value = current;
        }

        public void UpdateView(int current, int max)
        {
            HandleViewUpdate(current, max);
        }

        public abstract void HandleViewUpdate(int current, int max);
    }
}
