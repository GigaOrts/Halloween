using Halloween.Knockback;
using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(CharacterAnimations))]
    [RequireComponent(typeof(CharacterFlipper))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CharacterAnimations))]
    [RequireComponent(typeof(CharacterFlipper))]
    public sealed class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 100f;
        private Rigidbody2D _rigidbody;

        private Knockable _knockable;
        private CharacterAnimations _characterAnimations;
        private CharacterFlipper _characterFlipper;

        private void Awake()
        {
            _knockable = GetComponent<Knockable>();
            _rigidbody = GetComponent<Rigidbody2D>();
            _characterAnimations = GetComponent<CharacterAnimations>();
            _characterFlipper = GetComponent<CharacterFlipper>();
        }

        public void Move(Vector2 direction)
        {
            if (_knockable.IsKnocking)
                return;
            
            _rigidbody.velocity = new Vector2(_speed * direction.normalized.x, _rigidbody.velocity.y);
            
            if (direction.normalized.x == 0.0f)
            {
                _characterAnimations.EnableIdleAnimations();
                return;
            }
        
            _characterAnimations.EnableRunAnimations();
            if (_rigidbody.velocity.x > 0)
            {
                _characterFlipper.FlipRight();
                return;
            }
        
            _characterFlipper.FlipLeft();
        }
    }
}
