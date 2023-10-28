using UnityEngine;

namespace Halloween.Movement
{
    [RequireComponent(typeof(CharacterMovement))]
    public class CharacterInput : MonoBehaviour
    {
        private CharacterMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<CharacterMovement>();
        }

        private void FixedUpdate()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector2 movementDirection = new Vector2(horizontalInput, 0f);

            _movement.Move(movementDirection);
        }
    }
}