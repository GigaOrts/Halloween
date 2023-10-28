using Halloween.Character.Movement;
using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(CharacterMovement))]
    public sealed class Character : MonoBehaviour
    {
        private CharacterMovement _characterMovement;

        private void Awake() 
            => _characterMovement = GetComponent<CharacterMovement>();

        public void Move(Vector2 direction)
        {
            _characterMovement.Move(direction);
        }
    }
}