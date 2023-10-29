using System.Collections;
using Halloween.Health;
using UnityEngine;

namespace Halloween.Character
{
    public sealed class CharacterHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private CharacterAnimations _characterAnimations;
        private readonly IHealth _health = new Health.Health(5);
        
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
    }
}