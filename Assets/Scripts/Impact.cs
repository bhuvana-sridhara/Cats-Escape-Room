using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{
    
    public AudioSource impactSound;

    void OnCollisionEnter(Collision collision){
    	if(collision.relativeVelocity.magnitude > 7){
    		Debug.Log(collision.relativeVelocity.magnitude);
    		impactSound.Play();
    	}
    }
}
