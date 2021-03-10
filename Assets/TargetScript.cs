using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class TargetScript : MonoBehaviour
{
    public Score scoreManager;
    public Transform sparkle;
   
   public AudioSource source;
    //this method is called whenever a collision is detected

    void Start(){
         sparkle.GetComponent<ParticleSystem> ().enableEmission = false;
         source = GetComponent<AudioSource>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        scoreManager.AddChip();
        source.Play();
        sparkle.GetComponent<ParticleSystem> ().enableEmission = true;
    
        // printing if collision is detected on the console
        Debug.Log("Collision Detected");
       
        //after collision is detected destroy the gameobject
        StartCoroutine(stopSparkles());
        Debug.Log("End coroutine");
        // Destroy(gameObject);
         gameObject.GetComponent<Collider>() .enabled = false;
        gameObject.GetComponent<Renderer>() .enabled = false;
         
        

    }
    IEnumerator stopSparkles(){
        Debug.Log("wait");
        yield return new WaitForSeconds(5);
        Debug.Log("Sparkles stopped");
        sparkle.GetComponent<ParticleSystem> ().enableEmission = false;
    }


}