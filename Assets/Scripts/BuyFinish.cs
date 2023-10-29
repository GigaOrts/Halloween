using Halloween.Interactions;
using System.Collections;
using UnityEngine;

namespace Halloween
{
    public class BuyFinish : MonoBehaviour
    {
        [SerializeField] private InteractingZone _interactingZone;
        [SerializeField] private Wallet.Wallet _wallet;
        [SerializeField] private GameObject _endFrame;

        private bool isPressed;

        private CanvasGroup _canvasGroup;

        private void Start()
        {
            _canvasGroup = _endFrame.GetComponent<CanvasGroup>();
        }

        private void Update()
        {
            if (_interactingZone.IsCharacterInZone && _wallet.Coins >= 200 && UnityEngine.Input.GetKeyDown(KeyCode.E))
            {
                if (isPressed)
                    return;

                StartCoroutine(FadeIn());
            }
        }

        private IEnumerator FadeIn()
        {
            isPressed = true;
            while (_canvasGroup.alpha <= 1)
            {
                _canvasGroup.alpha = Mathf.MoveTowards(_canvasGroup.alpha, 1, Time.deltaTime * 0.8f);
                yield return null;
            }
        }
    }
}
