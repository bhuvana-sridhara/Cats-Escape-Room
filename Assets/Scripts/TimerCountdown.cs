using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public GameObject loseText;
    public GameObject winText;
    public Score ScoreManager;
    public GameObject chipsLeftCount;
    
   public int secondsLeft = 20;
   public int newSecondsleft;
   public bool takingAway = false;
    bool winFlag = false;



   void Start(){
   	textDisplay.GetComponent<Text>().text = "Go!";
   	loseText.SetActive(false);
    winText.SetActive(false);
    }

   void Update(){
        if(takingAway ==false && secondsLeft >0)
        {

            StartCoroutine(TimerTake());
        
   
        }
        print(ScoreManager.myTotalChips() - ScoreManager.myCurrentChips());
        chipsLeftCount.GetComponent<Text>().text = "" + ((ScoreManager.myTotalChips()) - (ScoreManager.myCurrentChips())) + " Chips are left in the office to find!";
    }
   IEnumerator TimerTake(){

   	takingAway = true;
   	yield return new WaitForSeconds(1);
   	secondsLeft-=1;

    if(ScoreManager.myCurrentChips() == ScoreManager.myTotalChips())
        {
            winFlag = true;
            winText.SetActive(true);
            secondsLeft = 0;

        }

   	if(secondsLeft < 10){
  		
   		textDisplay.GetComponent<Text>().text = "00:0"+secondsLeft;
   	}
   	else if(secondsLeft >= 60)
    {

   	    newSecondsleft = secondsLeft-60;
   		if(newSecondsleft <10)
        {
   			textDisplay.GetComponent<Text>().text = "01:0"+newSecondsleft;
   		}
   		else
        {
   			textDisplay.GetComponent<Text>().text = "01:"+newSecondsleft;
   		}
   		
   	}
   	else
    {
   		textDisplay.GetComponent<Text>().text = "00:"+secondsLeft;
   	}

   	if(secondsLeft == 0)
    {
        if(winFlag == true)
        {
              
        }
        else
        {
			loseText.SetActive(true);
        }
    }
   
   	takingAway = false;
   }
}
