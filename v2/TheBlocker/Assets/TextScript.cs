using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public static int score=0;
    Text text;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        text=GetComponent<Text>();
        score=0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BlockGenerator.startState==1){
        text.text=""+score;
        }
    }
}
