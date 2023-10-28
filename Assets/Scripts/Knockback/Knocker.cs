using UnityEngine;

namespace Halloween.Knockback
{
    public sealed class Knocker : MonoBehaviour
    {
        [SerializeField] private float _strength;
        [SerializeField] private float _knockTimeInSeconds;
        
        private void OnTriggerEnter2D(Collider2D collisionObject)
        {
            if (collisionObject.TryGetComponent(out Knockable knockable) && !knockable.IsKnocking)
                knockable.KnockCoroutine((collisionObject.transform.position - transform.position) * _strength, _knockTimeInSeconds);
        }
    }
}