using System.Collections;
using Halloween.Health;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Halloween.Character
{
    public sealed class CharacterHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private CharacterAnimations _characterAnimations;

        [Space] 
        [SerializeField] private int _healthValue;
        [SerializeField] private HealthView _healthView;
        
        private IHealth _health;
        private const string _valueSaveName = "CharacterHealth"; 
        
        public int Value 
            => _health.Value;

        public bool IsAlive 
            => _health.IsAlive;

        public void TakeDamage(int damage)
        {
            _health.TakeDamage(damage);
            PlayerPrefs.SetInt(_valueSaveName, Value);
            
            if (IsAlive) 
                return;
            
            _rigidbody.velocity = Vector2.zero;
            _characterAnimations.PlayDeathAnimation();
            PlayerPrefs.SetInt(_valueSaveName, _healthValue);
            StartCoroutine(ReloadScene());
        }

        private IEnumerator ReloadScene()
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        private void Awake()
        {
            var initialHealth = PlayerPrefs.HasKey(_valueSaveName) ? PlayerPrefs.GetInt(_valueSaveName) : _healthValue;
            _health = new Health.Health(_healthView, initialHealth);
        }
    }
}