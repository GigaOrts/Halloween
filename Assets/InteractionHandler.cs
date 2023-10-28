using UnityEngine;

namespace Halloween
{
    public class InteractionHandler : MonoBehaviour
    {
        [SerializeField] GameObject _buttonSprite;

        private void Start()
        {
            _buttonSprite.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.TryGetComponent(out SlotMachine slotMachine))
            {
                _buttonSprite.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out SlotMachine slotMachine))
            {
                _buttonSprite.SetActive(false);
            }
        }
    }
}
