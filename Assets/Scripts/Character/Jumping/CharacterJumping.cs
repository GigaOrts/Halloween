using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(IsCharacterGrounded))]
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class CharacterJumping : MonoBehaviour
    {
        [SerializeField] private float _jumpForce;
        
        private Rigidbody2D _rigidbody;
        private IsCharacterGrounded _isCharacterGrounded;
        
        public void StartJump()
        {
            Debug.Log(_isCharacterGrounded.Get());
            
            if (_isCharacterGrounded.Get())
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpForce);
        }

        public void EndJump()
        {
            if (_rigidbody.velocity.y > 0)
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y / 2f);
        }

        private void Awake()
        {
            _isCharacterGrounded = GetComponent<IsCharacterGrounded>();
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    }
}