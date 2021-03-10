using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class scriptzero : MonoBehaviour

{

	[SerializeField]
	private Transform puzzle_0;
	private Vector2 initialPosition;
	private float deltaX, deltaY;
	public static bool locked;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    	
        if(Input.GetMouseButton(0) && !locked){
        	
        	Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MonoBehaviour.print(mousePos.x);
            MonoBehaviour.print(mousePos.y);
			transform.position = new Vector2(mousePos.x, mousePos.y );
            MonoBehaviour.print("New position for puzzle 0"); 

        }

        if(Input.GetMouseButtonUp(0) && !locked){
        	
        	if(Math.Abs(transform.position.x - puzzle_0.position.x) <= 0.5f &&
        		Math.Abs(transform.position.y - puzzle_0.position.y) <= 0.5f){
        		transform.position = new Vector2(puzzle_0.position.x, puzzle_0.position.y);
        		locked = true;
        	}
        	else{
        		transform.position = new Vector2(initialPosition.x, initialPosition.y);
        	}
        }
       

    }
}
