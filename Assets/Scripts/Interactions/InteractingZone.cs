using UnityEngine;

namespace Halloween.Interactions
{
    public class InteractingZone : MonoBehaviour
    {
        [SerializeField] private GameObject _buttonImage;

        public bool IsCharacterInZone { get; private set; }

        private void Start() 
            => _buttonImage.SetActive(false);

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.TryGetComponent(out Character.Character _)) 
                return;
            
            _buttonImage.SetActive(true);
            IsCharacterInZone = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (!collision.gameObject.TryGetComponent(out Character.Character _))
                return;
            
            _buttonImage.SetActive(false);
            IsCharacterInZone = false;
        }
    }
}
