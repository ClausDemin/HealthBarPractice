using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.UI.Buttons
{
    [RequireComponent(typeof(Button))]
    public abstract class AbstractButton: MonoBehaviour
    {
        protected Button _Button;

        protected virtual void Awake()
        {
            _Button = GetComponent<Button>();
        }

        protected virtual void Start()
        {
            _Button.onClick.AddListener(() => OnClick());
        }

        protected virtual void OnDestroy()
        {
            _Button.onClick.RemoveListener(() => OnClick());
        }

        public abstract void OnClick();
    }
}
