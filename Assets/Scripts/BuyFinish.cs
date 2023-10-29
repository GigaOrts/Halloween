using Halloween.Interactions;
using UnityEngine;

namespace Halloween
{
    public class BuyFinish : MonoBehaviour
    {
        [SerializeField] private InteractingZone _interactingZone;
        [SerializeField] private Wallet.Wallet _wallet;

        private void Update()
        {
            if (_interactingZone.IsCharacterInZone && _wallet.Coins >= 200)
            {
                // end logic here
            }
        }
    }
}
