using System;
using UnityEngine;
using UnityEngine.Events;

public enum MovingDirection
{
    FORWARD,BACKWORK,LEFT,RIGHT,NONE
}

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0f, 50f)]
    [Tooltip("Speed of the player movemet")]
    [SerializeField]
    private float movementSpeed = 10.0f;

    [SerializeField]
    private Rigidbody rigidBody = null;


    [SerializeField]
    private InputHandler inputHandler;

    [SerializeField]
    private Transform camTransform = null;

    public MovingDirection MovingDirection
    {
        get 
        {
            if(inputHandler.MovementInput.z > 0)
                return MovingDirection.FORWARD;
            else if (inputHandler.MovementInput.z < 0) 
                return MovingDirection.BACKWORK;

            if (inputHandler.MovementInput.x > 0)
                return MovingDirection.RIGHT;
            else if (inputHandler.MovementInput.x < 0)
                return MovingDirection.LEFT;

            return MovingDirection.NONE;
        }
    }





    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();




    }

    private void rotatePlayer()
    {
        //transform.Rotate(0f , inputHandler.MouseInput.x * inputHandler.MouseSencivity, 0f);
        transform.rotation = Quaternion.Euler(0f, camTransform.eulerAngles.y, 0f);

    }

    void movePlayer()
    {
        if(inputHandler.MovementInput.normalized.magnitude > 0f)
        {
            Vector3 vector3 = inputHandler.MovementInput;
            vector3.x *= movementSpeed * 0.1f;
            vector3.z *= vector3.z < 0 ? movementSpeed * 0.4f : movementSpeed;
            Vector3 moveVector = camTransform.TransformDirection(vector3);
            rigidBody.velocity = new Vector3(moveVector.x , rigidBody.velocity.y , moveVector.z );

            rotatePlayer();
        }

    }

    private void FixedUpdate()
    {      

    }



}
