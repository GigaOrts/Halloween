using UnityEngine;

public class AnimationStateHandler : MonoBehaviour
{
    private readonly Vector3 _xPositiveScale = new(1, 1, 1);
    private readonly Vector3 _xNegativeScale = new(-1, 1, 1);

    private readonly string _idleTrigger = "idle";
    private readonly string _runTrigger = "run";

    protected Animator Animator;

    public bool IsFlippedLeft { get; private set; }

    protected void Awake()
    {
        Animator = GetComponentInChildren<Animator>();
    }

    public void FlipSprite(float xVelocity)
    {
        switch (xVelocity)
        {
            case < 0:
                transform.localScale = _xNegativeScale;
                IsFlippedLeft = true;
                break;
            case > 0:
                transform.localScale = _xPositiveScale;
                IsFlippedLeft = false;
                break;
        }
    }

    public void SetMovementState(Vector2 velocity)
    {
        Animator.SetTrigger(velocity == Vector2.zero ? _idleTrigger : _runTrigger);
    }
}
