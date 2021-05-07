using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class AnimationState : BehaviourAbstract
{
    [SerializeField]
    private Animator
        _animator;

    protected override void Update()
    {
        switch (_playerState.CurrentState)
        {
            case PlayerStates.IDLE:
                // do nothing

                break;
            case PlayerStates.HOP_LEFT:
                _animator.SetBool("IsLeft", true);
                _animator.SetTrigger("Hop");
                
                break;
            case PlayerStates.HOP_RIGHT:
                _animator.SetBool("IsLeft", false);
                _animator.SetTrigger("Hop");

                break;
            case PlayerStates.FALL:
                break;
        }
    }
}
