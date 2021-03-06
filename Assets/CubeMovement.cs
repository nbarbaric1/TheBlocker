﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed= 20f;
    public float maxMovement=15f;

    public int startState=0;

    private Rigidbody rb;
    public TimeManager timeManager;
    
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        startState=0;
        Time.timeScale=1;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyUp(KeyCode.UpArrow)){
            startState=1;
        }

        if (startState==1)
        {
            float x= Input.GetAxis("Horizontal")*Time.fixedDeltaTime*speed;
            Vector3 newPosition= rb.position + Vector3.right*x;
            newPosition.x= Mathf.Clamp(newPosition.x, -maxMovement, maxMovement);
            rb.MovePosition(newPosition);
        }



        
    }

  
    void OnCollisionEnter()
    {
        SoundManager.PlaySound("cae");
        timeManager.slowDo();
        FindObjectOfType<GameManager>().EndGame();
        
        
    }

    public int getStartState(){
        return startState;
    }
}
