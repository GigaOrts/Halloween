using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(CharacterJumping))]
    [RequireComponent(typeof(CharacterMovement))]
    public sealed class Character : MonoBehaviour
    {
        private CharacterJumping _characterJumping;
        private CharacterMovement _characterMovement;

        private void Awake()
        {
            _characterJumping = GetComponent<CharacterJumping>();
            _characterMovement = GetComponent<CharacterMovement>();
        }

        public void Move(Vector2 direction)
        {
            _characterMovement.Move(direction);
        }

        public void StartJump()
        {
            _characterJumping.StartJump();
        }

        public void EndJump()
        {
            _characterJumping.EndJump();
        }
    }
}