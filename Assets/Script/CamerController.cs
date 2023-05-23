using Cinemachine;
using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : NetworkBehaviour
{
    [SerializeField]
    private CinemachineFreeLook cinemachineFreeLook = null;

    public CinemachineFreeLook CinemachineFreeLook
    {
        get { return cinemachineFreeLook;}
    }

    // Start is called before the first frame update
    void Start()
    {

        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }

        cinemachineFreeLook = FindObjectOfType<CinemachineFreeLook>();
        cinemachineFreeLook.Follow = this.gameObject.transform;
        cinemachineFreeLook.LookAt = this.gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {

    }

}
