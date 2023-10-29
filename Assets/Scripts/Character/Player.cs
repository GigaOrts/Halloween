﻿using Halloween.Input;
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

        private bool _isOpenExitMenu = false;

        private void Update()
        {
            _isOpenExitMenu = !_exitGameScreen.activeSelf;

            if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
                _exitGameScreen.SetActive(true);

            if (_isOpenExitMenu)
                _character.Move(new Vector2(_characterMovementInput.MovingValueX, 0));

            if (_characterJumpingInput.JumpButtonPressedThisFrame && _isOpenExitMenu)
                _character.StartJump();

            if (_characterJumpingInput.JumpButtonReleasedThisFrame && _isOpenExitMenu)
                _character.EndJump();

            if (_characterAttackInput.IsAttackPressedThisFrame && _isOpenExitMenu)
                _character.Attack();

        }
    }
}