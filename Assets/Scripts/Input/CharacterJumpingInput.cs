using UnityEngine;

namespace Halloween.Input
{
    public sealed class CharacterJumpingInput : MonoBehaviour
    {
        public bool JumpButtonPressedThisFrame 
            => UnityEngine.Input.GetButtonDown("Jump");
        
        public bool JumpButtonReleasedThisFrame 
            => UnityEngine.Input.GetButtonUp("Jump");
    }
}