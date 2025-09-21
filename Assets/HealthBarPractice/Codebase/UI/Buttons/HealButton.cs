using Assets.Codebase.GameLogic.Common.HealthBehavior;
using Assets.HealthBarPractice.Codebase.Common.HealBehavior;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.UI.Buttons
{
    [RequireComponent(typeof(HealComponent))]
    public class HealButton: AbstractButton
    {
        [SerializeField] private HealthComponent _healthComponent;

        private HealComponent _heal;

        protected override void Awake()
        {
            _heal = GetComponent<HealComponent>();
            base.Awake();
        }

        public override void OnClick()
        {
            _heal.Heal(_healthComponent);
        }
    }
}
