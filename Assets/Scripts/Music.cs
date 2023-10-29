using UnityEngine;

namespace Halloween
{
    public sealed class Music : MonoBehaviour
    {
        private static Music _instance;

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
                return;
            }
            
            Destroy(gameObject);
        }
    }
}