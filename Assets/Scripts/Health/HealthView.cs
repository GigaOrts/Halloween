using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Halloween.Health
{
    public sealed class HealthView : MonoBehaviour, IHealthView
    {
        [SerializeField] private List<Image> _hearts;
        
        public void Display(int health)
        {
            _hearts.ForEach(heart => heart.enabled = false);

            for (var i = 0; i < health; i++) 
                _hearts[i].enabled = true;
        }
    }
}