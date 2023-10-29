using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Halloween.Health
{
    public sealed class HealthView : MonoBehaviour, IHealthView
    {
        [SerializeField] private List<Image> _hearts;
        [SerializeField] private Sprite _fullHeartSprite;
        [SerializeField] private Sprite _emptyHeartSprite;
        
        public void Display(int health)
        {
            _hearts.ForEach(heart => heart.sprite = _emptyHeartSprite);

            for (var i = 0; i < health; i++) 
                _hearts[i].sprite = _fullHeartSprite;
        }
    }
}