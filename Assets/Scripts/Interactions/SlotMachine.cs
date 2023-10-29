using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Halloween.Interactions
{
    public sealed class SlotMachine : MonoBehaviour
    {
        [SerializeField] private InteractingZone _interactingZone;
        [SerializeField] private TMP_Text _infoText;

        [Space]
        [SerializeField] private Wallet.Wallet _wallet;
        [SerializeField] private int _bid;

        private Coroutine _textCoroutine;

        private void Update()
        {
            if (!_interactingZone.IsCharacterInZone || !UnityEngine.Input.GetKeyDown(KeyCode.E)) 
                return;

            if (_wallet.Coins < _bid * 2)
            {
                if (_textCoroutine != null)
                    StopCoroutine(_textCoroutine);
                
                _textCoroutine = StartCoroutine(ShowText("Мало денег", new Color(255, 0, 0)));
                return;
            }
            
            if (Random.Range(0, 2) == 0)
            {
                if (_textCoroutine != null)
                    StopCoroutine(_textCoroutine);
                    
                _textCoroutine = StartCoroutine(ShowText($"+{_bid}", new Color(0, 255, 0)));
                _wallet.AddCoins(_bid);
                return;
            }

            if (_textCoroutine != null)
                StopCoroutine(_textCoroutine);
            
            _textCoroutine = StartCoroutine(ShowText($"-{_bid * 2}", new Color(255, 0, 0)));
            _wallet.WithdrawCoins(_bid * 2);
        }

        private IEnumerator ShowText(string text, Color color)
        {
            _infoText.text = text;
            _infoText.gameObject.SetActive(true);
            _infoText.color = color;

            yield return new WaitForSeconds(2);
            _infoText.gameObject.SetActive(false);
        }
    }
}
