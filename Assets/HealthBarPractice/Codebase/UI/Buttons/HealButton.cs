using Assets.Codebase.GameLogic.Common.HealthBehavior;
using Assets.HealthBarPractice.Codebase.Common.HealBehavior;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.UI.Buttons
{
    [RequireComponent(typeof(HealComponent))]
    public class HealButton: MonoBehaviour
    {
        [SerializeField] private HealthComponent _healthComponent;

        private HealComponent _heal;
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _heal = GetComponent<HealComponent>();
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
            _heal.Heal(_healthComponent);
        }
    }
}
