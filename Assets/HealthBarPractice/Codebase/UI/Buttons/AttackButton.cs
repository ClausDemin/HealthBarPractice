using Assets.Codebase.GameLogic.Common.HealthBehavior;
using Assets.HealthBarPractice.Codebase.Common.AttackBehavior;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.UI.Buttons
{
    [RequireComponent(typeof(AttackComponent))]
    public class AttackButton : AbstractButton
    {
        [SerializeField] private HealthComponent _healthComponent;

        private AttackComponent _attack;

        public override void OnClick()
        {
            _attack.PerformAttack(_healthComponent);
        }

        protected override void Awake()
        {
            _attack = GetComponent<AttackComponent>();
            base.Awake();
        }
    }
}
