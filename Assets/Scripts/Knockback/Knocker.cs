using UnityEngine;

namespace Halloween.Knockback
{
    public sealed class Knocker : MonoBehaviour
    {
        [SerializeField] private float _strength;
        [SerializeField] private float _knockTimeInSeconds;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Knockable knockable) && !knockable.IsKnocking)
                knockable.KnockCoroutine((other.transform.position - transform.position) * _strength, _knockTimeInSeconds);
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out Knockable knockable) && !knockable.IsKnocking)
                knockable.KnockCoroutine((other.gameObject.transform.position - transform.position) * _strength, _knockTimeInSeconds);
        }
    }
}