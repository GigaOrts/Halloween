using System;
using UnityEngine;

namespace Halloween.Character.Movement
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
            _rigidbody.velocity = new Vector2(_speed * direction.normalized.x, _rigidbody.velocity.y);

            if (_rigidbody.velocity == Vector2.zero)
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
