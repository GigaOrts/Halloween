using Halloween.Input;
using UnityEngine;

namespace Halloween.Character
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private Character _character;
        
        [Space]
        [SerializeField] private CharacterMovementInput _characterMovementInput;
        [SerializeField] private CharacterJumpingInput _characterJumpingInput;
        [SerializeField] private CharacterAttackInput _characterAttackInput;
        
        private void Update()
        {
            _character.Move(new Vector2(_characterMovementInput.MovingValueX, 0));
            
            if (_characterJumpingInput.JumpButtonPressedThisFrame)
                _character.StartJump();
            
            if (_characterJumpingInput.JumpButtonReleasedThisFrame)
                _character.EndJump();
            
            if (_characterAttackInput.IsAttackPressedThisFrame)
                _character.Attack();
        }
    }
}