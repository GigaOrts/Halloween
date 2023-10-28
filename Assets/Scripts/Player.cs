using Halloween.Input;
using UnityEngine;

namespace Halloween
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private Character.Character _character;
        [SerializeField] private CharacterMovementInput _characterMovementInput;
        
        private void Update()
        {
            if (_characterMovementInput.MovingValueX != 0f)
                _character.Move(new Vector2(_characterMovementInput.MovingValueX, 0));
        }
    }
}