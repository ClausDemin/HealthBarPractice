using Assets.Codebase.GameLogic.Common.HealthBehavior;
using Assets.HealthBarPractice.Codebase.Common.AttackBehavior;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.UI.Buttons
{
    [RequireComponent(typeof(AttackComponent))]
    public class AttackButton: MonoBehaviour
    {
        [SerializeField] private HealthComponent _healthComponent;

        private AttackComponent _attack;
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _attack = GetComponent<AttackComponent>();
        }

        private void Start()
        {
            _button.onClick.AddListener(() => OnClick());
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(() => OnClick());
        }

        private void OnClick() 
        {
            _attack.PerformAttack(_healthComponent);
        }
    }
}
