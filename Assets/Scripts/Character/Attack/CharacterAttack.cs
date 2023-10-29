using Halloween.Health;
using UnityEngine;

namespace Halloween.Character
{
    public sealed class CharacterAttack : MonoBehaviour
    {
        [SerializeField] private int _damage;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out IHealth health) && health.IsAlive) 
                health.TakeDamage(_damage);
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out IHealth health) && health.IsAlive) 
                health.TakeDamage(_damage);
        }
    }
}