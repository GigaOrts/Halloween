using UnityEngine;
using UnityEngine.SceneManagement;

namespace Halloween
{
    public class LevelTrigger : MonoBehaviour
    {
        [SerializeField] private LayerMask _maskCharacter;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out Character.Character character))
                SceneManager.LoadScene(sceneBuildIndex: 1);
        }
    }
}