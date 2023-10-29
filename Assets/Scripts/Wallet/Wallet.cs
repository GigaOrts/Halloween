using UnityEngine;

namespace Halloween.Wallet
{
    public class Wallet : MonoBehaviour
    {
        [SerializeField] private WalletView _walletView;
        private const string _coinsSaveName = "PlayerCoins";
        
        public int Coins { get; private set; }

        private void Awake()
        {
            Coins = PlayerPrefs.HasKey(_coinsSaveName) ? PlayerPrefs.GetInt(_coinsSaveName) : 0; 
            _walletView.Display(Coins);
        }

        public void AddCoins(int amount)
        {
            Coins += amount;
            _walletView.Display(Coins);
            PlayerPrefs.SetInt(_coinsSaveName, Coins);
        }

        public void WithdrawCoins(int amount)
        {
            Coins -= amount;

            if (Coins < 0)
                Coins = 0;
            
            _walletView.Display(Coins);
            PlayerPrefs.SetInt(_coinsSaveName, Coins);
        }
    }
}