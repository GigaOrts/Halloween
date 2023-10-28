using Halloween.Health;
using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(CharacterJumping))]
    [RequireComponent(typeof(CharacterMovement))]
    [RequireComponent(typeof(IHealth))]
    public sealed class Character : MonoBehaviour
    {
        private CharacterJumping _characterJumping;
        private CharacterMovement _characterMovement;
        private IHealth _health;

        private void Awake()
        {
            _characterJumping = GetComponent<CharacterJumping>();
            _characterMovement = GetComponent<CharacterMovement>();
            _health = GetComponent<IHealth>();
        }

        public void Move(Vector2 direction)
        {
            if (_health.IsAlive)
                _characterMovement.Move(direction);
        }

        public void StartJump()
        {
            if (_health.IsAlive)
                _characterJumping.StartJump();
        }

        public void EndJump()
        {
            if (_health.IsAlive)
                _characterJumping.EndJump();
        }
    }
}