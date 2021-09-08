using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
     public void back() {
        SceneManager.LoadScene("MainMenu");
    } 
}
