using TMPro;
using UnityEngine;

namespace Halloween
{
    public class ViewWallet : MonoBehaviour
    {
        [SerializeField] private TMP_Text _coinsText;

        public void UpdateUi(int coins) => 
            _coinsText.text = coins.ToString();
    }
}