using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
  



    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y<-3)
        {
            SoundManager.PlaySound("yes");
            Destroy(gameObject);  

           TextScript.score+=1;  
        }
        
    }
}
