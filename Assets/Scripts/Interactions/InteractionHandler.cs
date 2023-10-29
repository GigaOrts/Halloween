using UnityEngine;

namespace Halloween.Interactions
{
    public class InteractionHandler : MonoBehaviour
    {
        [SerializeField] private GameObject _buttonImage;

        private void Start() 
            => _buttonImage.SetActive(false);

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out SlotMachine slotMachine)) 
                _buttonImage.SetActive(true);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out SlotMachine slotMachine)) 
                _buttonImage.SetActive(false);
        }
    }
}
