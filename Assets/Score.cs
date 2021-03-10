using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Score : NetworkBehaviour
{

    public GameObject doorObject;
    public int totalChips = 1;
    [SyncVar]
    public int currentChipCount;

    public AudioSource win;
    // Start is called before the first frame update
    void Start()
    {
    	win = GetComponent<AudioSource>();
        if (isServer)
        {
            currentChipCount = 0;
        }

    }

    // whenever the player collects a chip we will add a point
    public void AddChip()
    {
        currentChipCount++;


        if (currentChipCount == totalChips)
        {
        	win.Play();
            Destroy(doorObject);

        }
    }

    public int myCurrentChips()
    {

        return currentChipCount;


    }
    public int myTotalChips()
    {
        return totalChips;
    }
}
