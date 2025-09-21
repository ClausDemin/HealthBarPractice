using UnityEngine;
using UnityEngine.UI;

namespace Assets.HealthBarPractice.Codebase.UI.Buttons
{
    [RequireComponent(typeof(Button))]
    public abstract class AbstractButton: MonoBehaviour
    {
        protected Button Button;

        protected virtual void Awake()
        {
            Button = GetComponent<Button>();
        }

        protected virtual void Start()
        {
            Button.onClick.AddListener(OnClick);
        }

        protected virtual void OnDestroy()
        {
            Button.onClick.RemoveListener(OnClick);
        }

        public abstract void OnClick();
    }
}
