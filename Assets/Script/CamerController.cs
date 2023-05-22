using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    [SerializeField]
    private float xRotation;

    [SerializeField] 
    private InputHandler inputHandler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        camerRotation();

    }


    void camerRotation()
    {
        xRotation -= inputHandler.MouseInput.y * inputHandler.MouseSencivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 40f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
