using UnityEngine;
using UnityEngine.SceneManagement;

namespace Halloween.Triggers
{
    public class NewSceneTrigger : MonoBehaviour
    {
        [SerializeField] private int _sceneIndex;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Character.Character _))
                SceneManager.LoadScene(_sceneIndex);
        }
    }
}