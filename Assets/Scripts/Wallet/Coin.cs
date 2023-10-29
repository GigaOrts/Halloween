using UnityEngine;

namespace Halloween.Wallet
{
    public sealed class Coin : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private GameObject _walletGameObject;

        private void OnEnable() 
            => _walletGameObject = FindObjectOfType<Wallet>().gameObject;

        private void Update() 
            => transform.position = Vector2.MoveTowards(transform.position, _walletGameObject.transform.position, _speed * Time.deltaTime);

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.TryGetComponent(out Wallet wallet)) 
                return;
            
            wallet.AddCoins(1);
            Destroy(gameObject);
        }
    }
}