using UnityEngine;

namespace Halloween.Input
{
    public sealed class CharacterMovementInput : MonoBehaviour
    {
        public float MovingValueX
            => UnityEngine.Input.GetAxisRaw("Horizontal");
    }
}