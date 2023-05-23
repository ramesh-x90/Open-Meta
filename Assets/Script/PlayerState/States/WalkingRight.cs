using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingRight : PlayerState
{
    public WalkingRight(PlayerStateManager playerStateManager) : base(playerStateManager)
    {
    }

    public override void EnterState()
    {
        playerStateManager.Animator.SetBool("isWalkingRight", true);
    }

    public override void ExitState()
    {
        playerStateManager.Animator.SetBool("isWalkingRight", false);
    }

    public override void UpdateState()
    {
        if (playerStateManager.CharacterController.MovingDirection != MovingDirection.RIGHT)
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.Idle);
        }
    }
}
