using Halloween.Character;
using Halloween.Knockback;
using UnityEngine;

namespace Halloween.Enemy
{
    [RequireComponent(typeof(CharacterMovement))]
    [RequireComponent(typeof(CharacterFlipper))]
    public class EnemyPatrol : MonoBehaviour
    {
        [SerializeField] private float _raycastDistance = 1.0f;
        [SerializeField] private Knockable _knockable;
        [SerializeField] private LayerMask _obstacleLayerMask;

        private CharacterMovement _movement;
        private CharacterFlipper _flipper;

        private void Awake()
        {
            _movement = GetComponent<CharacterMovement>();
            _flipper = GetComponent<CharacterFlipper>();
        }

        private void FixedUpdate()
        {
            if (_knockable.IsKnocking)
                return;
            
            var direction = _flipper.IsFlippedLeft ? Vector2.left : Vector2.right;
            var hit = Physics2D.Raycast(transform.position, direction, _raycastDistance, _obstacleLayerMask);

            if (hit.collider) 
                direction = _flipper.IsFlippedLeft ? Vector2.right : Vector2.left;

            _movement.Move(direction);
        }
    }
}