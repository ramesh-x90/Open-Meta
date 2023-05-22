using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationState : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private CharacterController characterController;

    [SerializeField]
    private Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.MovingDirection == MovingDirection.FORWARD)
        {
            animator.SetBool("isRunningForward", true);
            animator.SetBool("isWalkingBackward", false);
            animator.SetBool("isWalkingLeft", false);
            animator.SetBool("isWalkingRight", false);
        }
        else if (characterController.MovingDirection == MovingDirection.BACKWORK)
        {
            animator.SetBool("isWalkingBackward", true);
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isWalkingLeft", false);
            animator.SetBool("isWalkingRight", false);

        }
        else if (characterController.MovingDirection == MovingDirection.LEFT)
        {
            animator.SetBool("isWalkingBackward", false);
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isWalkingLeft", true);
            animator.SetBool("isWalkingRight", false);
        }
        else if (characterController.MovingDirection == MovingDirection.RIGHT)
        {
            animator.SetBool("isWalkingBackward", false);
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isWalkingLeft", false);
            animator.SetBool("isWalkingRight", true);
        }
        else
        {
            animator.SetBool("isWalkingBackward", false);
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isWalkingLeft", false);
            animator.SetBool("isWalkingRight", false);
        }
    }
}
