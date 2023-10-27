using UnityEngine;

namespace Halloween.Movement
{
    public sealed class CharacterAnimations : MonoBehaviour
    {
        private Animator _animator;
    
        private readonly int idleTriggerHash = Animator.StringToHash("idle");
        private readonly int runTriggerHash = Animator.StringToHash("run");

        private void Awake() 
            => _animator = GetComponentInChildren<Animator>();

        public void SetIdleAnimation()
            => _animator.SetTrigger(idleTriggerHash);
    
        public void SetRunAnimation()
            => _animator.SetTrigger(runTriggerHash);
    }
}