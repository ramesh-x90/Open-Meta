using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : PlayerState
{
    public Idle(PlayerStateManager playerStateManager) : base(playerStateManager)
    {
    }

    public override void EnterState()
    {
        playerStateManager.Animator.SetBool("isIdle", true);
    }

    public override void ExitState()
    {
        playerStateManager.Animator.SetBool("isIdle", false);
    }

    public override void UpdateState()
    {
        if (playerStateManager.CharacterController.MovingDirection == MovingDirection.FORWARD)
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.Running);
        }

        if (playerStateManager.CharacterController.MovingDirection == MovingDirection.BACKWORK)
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.WalkingBackWard);
        }

        if (playerStateManager.CharacterController.MovingDirection == MovingDirection.LEFT)
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.WalkingLeft);
        }

        if (playerStateManager.CharacterController.MovingDirection == MovingDirection.RIGHT)
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.WalkingRight);
        }
    }
}
