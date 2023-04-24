using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float mSpeed = 2.0f;
    [SerializeField]
    private Rigidbody rigidbody = null;

    private float horizontalInput;
    private float verticalInput;


    void Start()
    {
        Debug.Log("Hello world");
        rigidbody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {       
        rigidbody.velocity = new Vector3(horizontalInput, rigidbody.velocity.y, verticalInput) * mSpeed;
    }



}
