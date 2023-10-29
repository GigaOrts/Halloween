using UnityEngine;

namespace Halloween
{
    public class FinishBuy : MonoBehaviour
    {
        [SerializeField] private GameObject _viewCost;

        private void Start()
        {
            _viewCost.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.TryGetComponent(out Character.Character character))
            {
                _viewCost.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out Character.Character character))
            {
                _viewCost.SetActive(false);
            }
        }
    }
}
