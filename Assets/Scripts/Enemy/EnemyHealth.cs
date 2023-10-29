using Halloween.Health;
using UnityEngine;

namespace Halloween.Enemy
{
    public sealed class EnemyHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private int _healthValue;
        private IHealth _health;
        
        public int Value 
            => _health.Value;

        public bool IsAlive 
            => _health.IsAlive;

        public void TakeDamage(int damage)
        {
            _health.TakeDamage(damage);

            if (!IsAlive) 
                Destroy(gameObject);
        }

        private void Awake()
            => _health = new Health.Health(new EnemyHealthView(), _healthValue);
    }
}