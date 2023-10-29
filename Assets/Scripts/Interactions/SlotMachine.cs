using UnityEngine;

namespace Halloween.Interactions
{
    public sealed class SlotMachine : MonoBehaviour
    {
        [SerializeField] private InteractingZone _interactingZone;

        [Space]
        [SerializeField] private Wallet.Wallet _wallet;
        [SerializeField] private int _bid;

        private void Update()
        {
            if (!_interactingZone.IsCharacterInZone || _wallet.Coins < _bid * 2 || !UnityEngine.Input.GetKeyDown(KeyCode.E)) 
                return;
            
            var multiplier = Random.Range(0, 2) == 0 ? -2 : 1;
            _wallet.AddCoins(_bid * multiplier);
        }
    }
}
