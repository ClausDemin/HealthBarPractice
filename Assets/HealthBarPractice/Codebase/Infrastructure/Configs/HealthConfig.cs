using UnityEngine;

namespace Assets.HealthBarPractice.Codebase.Infrastructure.Configs
{
    [CreateAssetMenu(menuName = "Configs/Health", fileName = "HealthConfig")]
    public class HealthConfig: ScriptableObject
    {
        [field: SerializeField] public int Max { get; private set; }
    }
}
