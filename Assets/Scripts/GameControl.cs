using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject WinText;
    // Start is called before the first frame update
    void Start()
    {
        WinText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(scriptzero.locked)
            WinText.SetActive(true);
    }
}
