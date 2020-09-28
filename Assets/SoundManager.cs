using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip collisionSound, yesSound;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        collisionSound= Resources.Load<AudioClip>("cae");
        yesSound= Resources.Load<AudioClip>("yes");

        audioSource=GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void PlaySound(string clip){
        switch (clip)
        {
            case "cae":
                audioSource.PlayOneShot(collisionSound);
                break;
            case "yes":
                audioSource.PlayOneShot(yesSound);
                break;
            
        }
    }


}
