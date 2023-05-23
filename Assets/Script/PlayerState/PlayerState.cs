using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PlayerState 
{
    protected PlayerStateManager playerStateManager;
    public PlayerState(PlayerStateManager playerStateManager) {
        this.playerStateManager = playerStateManager;
    }
    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
}
