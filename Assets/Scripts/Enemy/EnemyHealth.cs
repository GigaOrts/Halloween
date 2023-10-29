using Halloween.Health;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Halloween.Enemy
{
    public sealed class EnemyHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private int _healthValue;
        [SerializeField] private GameObject _coinPrefab;
        
        private IHealth _health;
        
        public int Value 
            => _health.Value;

        public bool IsAlive 
            => _health.IsAlive;

        public void TakeDamage(int damage)
        {
            _health.TakeDamage(damage);

            if (IsAlive) 
                return;
            
            var coinsCount = Random.Range(0, 4) == 0 ? 3 : 2;

            for (var _ = 0; _ < coinsCount; _++)
                Instantiate(_coinPrefab, transform.position + new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0), quaternion.identity);

            Destroy(gameObject);
        }

        private void Awake()
            => _health = new Health.Health(new EnemyHealthView(), _healthValue);
    }
}