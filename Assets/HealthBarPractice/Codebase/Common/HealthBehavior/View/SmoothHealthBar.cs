using Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View.Interface;
using System.Collections;
using UnityEngine;

namespace Assets.HealthBarPractice.Codebase.Common.HealthBehavior.View
{
    public class SmoothHealthBar : SliderBar
    {
        [SerializeField] private float _changeDuration;
        
        private Coroutine _animation;

        private IEnumerator ChangeValue(int target) 
        {
            float framesCount = _changeDuration / Time.deltaTime;
            float changeStep = Mathf.Abs((_Bar.value - target) / framesCount);

            while (_Bar.value != target) 
            {
                _Bar.SetValueWithoutNotify(Mathf.MoveTowards(_Bar.value, target, changeStep));

                yield return null;
            }

            _animation = null;
            yield break;
        }

        public override void HandleViewUpdate(int current, int max)
        {
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
    }
}
