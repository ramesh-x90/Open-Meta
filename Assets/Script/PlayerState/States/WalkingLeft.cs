using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingLeft : PlayerState
{
    public WalkingLeft(PlayerStateManager playerStateManager) : base(playerStateManager)
    {
    }

    public override void EnterState()
    {
        playerStateManager.Animator.SetBool("isWalkingLeft", true);

    }

    public override void ExitState()
    {
        playerStateManager.Animator.SetBool("isWalkingLeft", false);
    }

    public override void UpdateState()
    {
        if(playerStateManager.CharacterController.MovingDirection != MovingDirection.LEFT)
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.Idle);
        }
    }
}
