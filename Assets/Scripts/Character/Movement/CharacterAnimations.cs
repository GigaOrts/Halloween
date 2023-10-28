using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(Animator))]
    public sealed class CharacterAnimations : MonoBehaviour
    {
        private Animator _animator;

        private readonly int IDLE_TRIGGER_HASH = Animator.StringToHash("Idle");
        private readonly int RUN_RIGGER_HASH = Animator.StringToHash("Run");

        private void Awake() 
            => _animator = GetComponent<Animator>();

        public void EnableIdleAnimations()
            => _animator.SetTrigger(IDLE_TRIGGER_HASH);
    
        public void EnableRunAnimations()
            => _animator.SetTrigger(RUN_RIGGER_HASH);
    }
}