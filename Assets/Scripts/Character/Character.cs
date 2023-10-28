using Halloween.Health;
using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(CharacterJumping))]
    [RequireComponent(typeof(CharacterMovement))]
    [RequireComponent(typeof(IHealth))]
    public sealed class Character : MonoBehaviour
    {
        private IHealth _health;
        private CharacterJumping _characterJumping;
        private CharacterMovement _characterMovement;
        private CharacterAttacking _characterAttacking;

        private void Awake()
        {
            _characterJumping = GetComponent<CharacterJumping>();
            _characterMovement = GetComponent<CharacterMovement>();
            _characterAttacking = GetComponent<CharacterAttacking>();
            _health = GetComponent<IHealth>();
        }

        public void Move(Vector2 direction)
        {
            if (_health.IsAlive)
                _characterMovement.Move(direction);
        }

        public void Attack()
        {
            if (_health.IsAlive)
                _characterAttacking.Attack();
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