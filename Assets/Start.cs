using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnRightClick() //
{
 // if(other.tag == "MainCamera") //telling the OnTriggerEvent if something tagged "Player" collides then do the following. In this case
// //we tell it to LoadScene using areaToLoad variable we created 
 //{
 
 		MonoBehaviour.print("Start");
 		SceneManager.LoadScene("SampleScene");
 	
	

///}
}
}
