using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraScript : NetworkBehaviour
{
    public GameObject cameraGameObject;

    // Start is called before the first frame update




    void Start()
    {
        if (!isLocalPlayer)
        {

            /*cameraVariable.gameObject.SetActive(false);*/
            cameraGameObject.SetActive(false);
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}
