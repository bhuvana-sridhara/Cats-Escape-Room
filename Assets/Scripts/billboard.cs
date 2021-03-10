using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
	// public Transform camTransform;

	// Quaternion originalRotation;
	private Camera theCam;
    void Start()
    {
        // originalRotation = transform.rotation;
        theCam = Camera.main;

    }

    void LateUpdate()
    {
     	// transform.rotation = camTransform.rotation * originalRotation;   
     	transform.LookAt(theCam.transform);
     	Debug.Log("Transforming");
    }
}