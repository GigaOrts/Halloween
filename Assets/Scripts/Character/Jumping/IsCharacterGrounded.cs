using UnityEngine;

namespace Halloween.Character
{
    public sealed class IsCharacterGrounded : MonoBehaviour
    {
        [SerializeField] private Transform _groundCheckTransform;
        [SerializeField] private LayerMask _groundLayerMask;

        public bool Get()
            => Physics2D.OverlapCircle(_groundCheckTransform.position, 0.2f, _groundLayerMask);
    }
}