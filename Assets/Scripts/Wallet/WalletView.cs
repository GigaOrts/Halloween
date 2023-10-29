using TMPro;
using UnityEngine;

namespace Halloween.Wallet
{
    public class WalletView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _coinsText;

        public void Display(int coins) 
            => _coinsText.text = coins.ToString();
    }
}