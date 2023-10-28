using UnityEngine;

namespace Halloween.Character
{
    public sealed class CharacterFlipper : MonoBehaviour
    {
        private readonly Vector3 _xPositiveScale = new(1, 1, 1);
        private readonly Vector3 _xNegativeScale = new(-1, 1, 1);
    
        public bool IsFlippedLeft { get; private set; }

        public void FlipRight()
        {
            transform.localScale = _xPositiveScale;
            IsFlippedLeft = false;
        }

        public void FlipLeft()
        {
            transform.localScale = _xNegativeScale;
            IsFlippedLeft = true;
        }
    }
}