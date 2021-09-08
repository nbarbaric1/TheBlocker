using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowdownFactor=0.05f;
    public float slowdownLength=2f;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        /*  */
    }

    public void slowDo(){
        Time.timeScale=slowdownFactor;
        Time.fixedDeltaTime=Time.timeScale*0.02f;

    }
    
}
