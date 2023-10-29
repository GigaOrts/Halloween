using System;
using UnityEngine;

namespace Halloween
{
    public class Wallet : MonoBehaviour
    {
        [SerializeField] private ViewWallet _viewWallet;
        
        private int _coins = 0;

        private void Start() => 
            _viewWallet.UpdateUi(_coins);

        public void ChangeCoins(int amount)
        {
            _coins += amount;
            _viewWallet.UpdateUi(_coins);
        }
    }
}