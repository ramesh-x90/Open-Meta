using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningForward : PlayerState
{
    public RunningForward(PlayerStateManager playerStateManager) : base(playerStateManager)
    {
    }

    public override void EnterState()
    {
        playerStateManager.Animator.SetBool("isRunningForward", true);
    }

    public override void ExitState()
    {
        playerStateManager.Animator.SetBool("isRunningForward", false);
    }

    public override void UpdateState()
    {
        if (playerStateManager.CharacterController.MovingDirection != MovingDirection.FORWARD)
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.Idle);
        }
    }
}
