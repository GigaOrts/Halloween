using Halloween.Health;
using UnityEngine;

namespace Halloween.Traps
{
    public sealed class SpikeTrap : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out IHealth health)) 
                health.TakeDamage(health.Value);
        }
    }
}