using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public Transform[] generatePoints;
    public GameObject blockTemplate;
    private float timeToGenerate=2f;
    private float timeBetween=1f;
    public static int startState=0;
    

   
void Start()
{
    startState=0;
}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.UpArrow)){
            startState=1;
        }

        if (startState==1)
        {
           if(Time.time>timeToGenerate){
            generateBlocks();
            timeToGenerate=Time.time+timeBetween;
            timeBetween=timeBetween-0.003f;
            }    
        }
         
    }

    void generateBlocks(){

        int randomIndex= Random.Range(0, generatePoints.Length);

        for (int i = 0; i < generatePoints.Length; i++)
        {
            if(randomIndex!=i){
                Instantiate(blockTemplate,generatePoints[i].position,Quaternion.identity);
            }
        }




    }
}
