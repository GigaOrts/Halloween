using Halloween.Input;
using UnityEngine;

namespace Halloween.Character
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private GameObject _exitGameScreen;

        [Space]
        [SerializeField] private Character _character;

        [Space]
        [SerializeField] private CharacterMovementInput _characterMovementInput;
        [SerializeField] private CharacterJumpingInput _characterJumpingInput;
        [SerializeField] private CharacterAttackInput _characterAttackInput;

        private bool _isClosedExitMenu;

        private void Update()
        {
            _isClosedExitMenu = !_exitGameScreen.activeSelf;

            if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                _exitGameScreen.SetActive(true);
            }
            
            if (_isClosedExitMenu)
                _character.Move(new Vector2(_characterMovementInput.MovingValueX, 0));

            if (_characterJumpingInput.JumpButtonPressedThisFrame && _isClosedExitMenu)
                _character.StartJump();

            if (_characterJumpingInput.JumpButtonReleasedThisFrame && _isClosedExitMenu)
                _character.EndJump();

            if (_characterAttackInput.IsAttackPressedThisFrame && _isClosedExitMenu)
                _character.Attack();
        }
    }
}