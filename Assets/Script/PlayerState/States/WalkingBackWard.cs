using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingBackWard : PlayerState
{
    public WalkingBackWard(PlayerStateManager playerStateManager) : base(playerStateManager)
    {
    }

    public override void EnterState()
    {
        playerStateManager.Animator.SetBool("isWalkingBackward", true);
    }

    public override void ExitState()
    {
        playerStateManager.Animator.SetBool("isWalkingBackward", false);
    }

    public override void UpdateState()
    {
        if(playerStateManager.CharacterController.MovingDirection != MovingDirection.BACKWORK) 
        {
            ExitState();
            playerStateManager.SwitchState(playerStateManager.Idle);
        }

    }
}
