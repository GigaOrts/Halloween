using System.Collections;
using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(CharacterFlipper))]
    [RequireComponent(typeof(CharacterAnimations))]
    public sealed class CharacterAttacking : MonoBehaviour
    {
        [SerializeField] private GameObject _attackColliderGameObject;
        
        private CharacterAnimations _characterAnimations;
        private Coroutine _attackCoroutine;

        private void Awake() 
            => _characterAnimations = GetComponent<CharacterAnimations>();

        public void Attack()
        {
            if (_attackCoroutine != null)
                return;
            
            _attackCoroutine = StartCoroutine(AttackCoroutine());
        }

        private IEnumerator AttackCoroutine()
        {
            _characterAnimations.SetAttackBool(true);
            _attackColliderGameObject.SetActive(true);
            
            yield return new WaitForSeconds(0.2f);
            _characterAnimations.SetAttackBool(false);
            _attackColliderGameObject.SetActive(false);

            yield return new WaitForSeconds(0.2f);
            _attackCoroutine = null;
        }
    }
}