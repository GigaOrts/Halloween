using UnityEngine;

namespace Halloween.Input
{
    public sealed class CharacterAttackInput : MonoBehaviour
    {
        public bool IsAttackPressedThisFrame
            => UnityEngine.Input.GetMouseButtonDown(0);
    }
}