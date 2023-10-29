using System.Linq;
using UnityEngine;

namespace Halloween.Character
{
    [RequireComponent(typeof(Animator))]
    public sealed class CharacterAnimations : MonoBehaviour
    {
        private Animator _animator;

        private readonly int IDLE_TRIGGER_HASH = Animator.StringToHash("Idle");
        private readonly int RUN_TRIGGER_HASH = Animator.StringToHash("Run");
        private readonly int DEATH_TRIGGER_HASH = Animator.StringToHash("Death");
        private readonly int ATTACK_BOOL_HASH = Animator.StringToHash("Attack");

        private void Awake() 
            => _animator = GetComponent<Animator>();

        public void EnableIdleAnimations()
        {
            if (_animator.parameters.Any(parameter => parameter.type == AnimatorControllerParameterType.Trigger && parameter.name == "Idle"))
                _animator.SetTrigger(IDLE_TRIGGER_HASH);
        }

        public void EnableRunAnimations()
        {
            if (_animator.parameters.Any(parameter => parameter.type == AnimatorControllerParameterType.Trigger && parameter.name == "Run"))
                _animator.SetTrigger(RUN_TRIGGER_HASH);
        }

        public void PlayDeathAnimation()
        {
            if (_animator.parameters.Any(parameter => parameter.type == AnimatorControllerParameterType.Trigger && parameter.name == "Death")) 
                _animator.SetTrigger(DEATH_TRIGGER_HASH);
        }

        public void SetAttackBool(bool active)
        {
            if (_animator.parameters.Any(parameter => parameter.type == AnimatorControllerParameterType.Bool && parameter.name == "Attack"))
                _animator.SetBool(ATTACK_BOOL_HASH, active);
        }
    }
}