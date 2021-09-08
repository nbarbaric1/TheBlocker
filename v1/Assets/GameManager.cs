using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   
   
   public void EndGame(){
       StartCoroutine(ExampleCoroutine());
      
   }


    IEnumerator ExampleCoroutine()
    {

        
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSecondsRealtime(2);
        

         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

}
