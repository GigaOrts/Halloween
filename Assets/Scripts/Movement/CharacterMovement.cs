using UnityEngine;

namespace Halloween.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 100f;
        private Rigidbody2D _rigidbody;
    
        private CharacterAnimations _characterAnimations;
        private CharacterFlipper _characterFlipper;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _characterAnimations = GetComponent<CharacterAnimations>();
            _characterFlipper = GetComponent<CharacterFlipper>();
        }

        public void Move(Vector2 direction)
        {
            _rigidbody.velocity = Time.deltaTime * _speed * direction.normalized;

            if (_rigidbody.velocity == Vector2.zero)
            {
                _characterAnimations.SetIdleAnimation();
                return;
            }
        
            _characterAnimations.SetRunAnimation();
            if (_rigidbody.velocity.x > 0)
            {
                _characterFlipper.FlipRight();
                return;
            }
        
            _characterFlipper.FlipLeft();
        }
    }
}
