using UnityEngine;

namespace Halloween.Wallet
{
    public class Wallet : MonoBehaviour
    {
        [SerializeField] private WalletView _walletView;
        
        private int _coins ;
        private const string _coinsSaveName = "PlayerCoins";

        private void Awake()
        {
            _coins = PlayerPrefs.HasKey(_coinsSaveName) ? PlayerPrefs.GetInt(_coinsSaveName) : 0; 
            _walletView.Display(_coins);
        }

        public void AddCoins(int amount)
        {
            _coins += amount;
            _walletView.Display(_coins);
            PlayerPrefs.SetInt(_coinsSaveName, _coins);
        }

        public void WithdrawCoins(int amount)
        {
            _coins -= amount;

            if (_coins < 0)
                _coins = 0;
            
            _walletView.Display(_coins);
            PlayerPrefs.SetInt(_coinsSaveName, _coins);
        }
    }
}