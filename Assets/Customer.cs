using UnityEngine;

namespace Halloween
{
    public class Customer : MonoBehaviour
    {
        private Wallet.Wallet _wallet;

        private void Awake()
        {
            _wallet = GetComponent<Wallet.Wallet>();
        }

        private void Update()
        {
            if(UnityEngine.Input.GetKeyDown(KeyCode.E))
            {
                if(_wallet.Coins >= 200)
                {

                }
            }
        }
    }
}
