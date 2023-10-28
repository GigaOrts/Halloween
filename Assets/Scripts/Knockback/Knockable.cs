using System.Collections;
using UnityEngine;

namespace Halloween.Knockback
{
    public sealed class Knockable : MonoBehaviour
    {
        public bool IsKnocking { get; private set; }
        private Rigidbody2D _rigidbody;

        private void Awake() 
            => _rigidbody = GetComponent<Rigidbody2D>();

        public void KnockCoroutine(Vector2 forceVector, float timeInSeconds)
        {
            IsKnocking = true;
            _rigidbody.AddForce(forceVector, ForceMode2D.Impulse);
            StartCoroutine(EndKnocking(timeInSeconds));
        }

        private IEnumerator EndKnocking(float timeInSeconds)
        {
            yield return new WaitForSeconds(timeInSeconds);
            _rigidbody.velocity = Vector2.zero;
            IsKnocking = false;
        }
    }
}