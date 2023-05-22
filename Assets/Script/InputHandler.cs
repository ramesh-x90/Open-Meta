using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;  
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

enum InputEvents
{
    WASD,
    MOUSE_X,
    MOUSE_Y
}


class InputHandler : MonoBehaviour
{
    private Vector3 _movementInput;
    public Vector3 MovementInput
    {
        get
        {
            return _movementInput;
        }
        private set 
        {
            _movementInput = value;
        }
    }

    [SerializeField]
    private Vector2 _mouseInput;
    public Vector3 MouseInput
    {
        get
        {
            return _mouseInput;
        }
        private set
        {
            _mouseInput = value;
        }
    }

    [Range(0f, 10f)]
    [SerializeField]
    private float _mouseSencivity = 2f;
    public float MouseSencivity
    {
        get
        {
            return _mouseSencivity;
        }
        private set
        {
            _mouseSencivity = value;
        }
    }

    private void Start()
    {

    }

    private void Update()
    {
        MovementInput = new Vector3(Input.GetAxis(Constants.HAXIS), 0f, Input.GetAxis(Constants.VAXIS));
        MouseInput = new Vector2(Input.GetAxis(Constants.MOUSE_X), Input.GetAxis(Constants.MOUSE_Y));
    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }


}