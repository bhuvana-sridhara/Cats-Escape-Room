using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Scriptnine : MonoBehaviour

{

	[SerializeField]
	private Transform puzzle_9;
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
			transform.position = new Vector2(mousePos.x, mousePos.y );

        }

        if(Input.GetMouseButtonUp(0) && !locked){
        	
        	if(Math.Abs(transform.position.x - puzzle_9.position.x) <= 0.5f &&
        		Math.Abs(transform.position.y - puzzle_9.position.y) <= 0.5f){
        		transform.position = new Vector2(puzzle_9.position.x, puzzle_9.position.y);
        		locked = true;
        	}
        	else{
        		transform.position = new Vector2(initialPosition.x, initialPosition.y);
        	}
        }
       

    }
}
