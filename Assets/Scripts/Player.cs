using Halloween.Input;
using UnityEngine;

namespace Halloween
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private Character.Character _character;
        [SerializeField] private CharacterMovementInput _characterMovementInput;
        
        private void FixedUpdate()
        {
            Debug.Log(_characterMovementInput.MovingValueX);
            _character.Move(new Vector2(_characterMovementInput.MovingValueX, 0));
        }
    }
}