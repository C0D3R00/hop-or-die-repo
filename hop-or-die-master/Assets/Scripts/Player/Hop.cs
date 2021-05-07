using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class Hop : BehaviourAbstract
{
    [SerializeField]
    private VoidEvent
        _onHop;

    protected override void Update()
    {
        if (_playerState.CurrentState == PlayerStates.FALL) return;

        // reverse hop since camera is looking at the player from the front

        // disable script when powered up
        switch (_inputState.CurrentInput)
        {
            case InputNames.NONE:
                _playerState.CurrentState = PlayerStates.IDLE;

                break;
            case InputNames.TAP_LEFT:
                _playerState.CurrentState = PlayerStates.HOP_RIGHT;
                _onHop.Raise();

                break;
            case InputNames.TAP_RIGHT:
                _playerState.CurrentState = PlayerStates.HOP_LEFT;
                _onHop.Raise();

                break;
        }
    }
}
