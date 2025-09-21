using Assets.Codebase.GameLogic.Common.HealthBehavior.Interface;
using UnityEngine;

namespace Assets.HealthBarPractice.Codebase.Common.AttackBehavior
{
    public class AttackComponent: MonoBehaviour
    {
        [SerializeField] private int _damage;
        
        private IDamageable _target;

        public void Construct(IDamageable target) 
        { 
            _target = target;
        }

        public void PerformAttack(IDamageable target) 
        {
            target.TakeDamage(_damage);
        }
    }
}
