using Halloween.Health;
using UnityEngine;

namespace Halloween.Character
{
    public sealed class CharacterHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private CharacterAnimations _characterAnimations;

        [Space] 
        [SerializeField] private int _healthValue;
        [SerializeField] private HealthView _healthView;
        
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
            
            _rigidbody.velocity = Vector2.zero;
            _characterAnimations.PlayDeathAnimation();
        }

        private void Awake() 
            => _health = new Health.Health(_healthView, _healthValue);
    }
}