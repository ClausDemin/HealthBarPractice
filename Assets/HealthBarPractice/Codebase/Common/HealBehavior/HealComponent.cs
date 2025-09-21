using Assets.Codebase.GameLogic.Common.HealthBehavior.Interface;
using UnityEngine;

namespace Assets.HealthBarPractice.Codebase.Common.HealBehavior
{
    public class HealComponent : MonoBehaviour
    {
        [SerializeField] private int _healing;

        private IHealable _target;

        public void Construct(IHealable target)
        {
            _target = target;
        }

        public void Heal(IHealable target)
        {
            target.Increase(_healing);
        }
    }
}
