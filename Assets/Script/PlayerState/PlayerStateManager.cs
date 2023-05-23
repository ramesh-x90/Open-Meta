using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : NetworkBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private CharacterController _characterController;
    public CharacterController CharacterController
    {
        get { return _characterController; }    
    }

    [SerializeField]
    private Animator _animator;

    public Animator Animator
    {
        get { return _animator; }
    }



    private PlayerState currentState;

    private PlayerState _idle;
    public PlayerState Idle
    {
        get { return _idle; }
    }



    private PlayerState _running;
    public PlayerState Running
    {
        get { return _running; }
    }



    private PlayerState _walkingBackWard;
    public PlayerState WalkingBackWard
    {
        get { return _walkingBackWard; }
    }

    private PlayerState _walkingLeft;
    public PlayerState WalkingLeft
    {
        get { return _walkingLeft; }
    }


    private PlayerState _walkingRight;
    public PlayerState WalkingRight
    {
        get { return _walkingRight; }
    }




    void Start()
    {
        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }

        _idle = new Idle(this);
        _running = new RunningForward(this);
        _walkingBackWard = new WalkingBackWard(this);
        _walkingLeft = new WalkingLeft(this);
        _walkingRight = new WalkingRight(this);

        currentState = _idle;
        currentState.EnterState();


    }

    // Update is called once per frame
    void Update()
    {
        if(isLocalPlayer)
            currentState.UpdateState();
    }

    public void SwitchState(PlayerState playerState)
    {
        currentState = playerState;
        currentState.EnterState();

    }
}
