using Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View.Interface;

namespace Assets.HealthBarPractice.Codebase.Common.HealthBehavior
{
    public class HealthSliderView : SliderBar
    {
        public override void HandleViewUpdate(int current, int max)
        {
            if (_Bar.maxValue != max)
            {
                _Bar.maxValue = max;
            }

            _Bar.value = current;
        }
    }
}
