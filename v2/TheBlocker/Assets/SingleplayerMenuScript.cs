using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SingleplayerMenuScript : MonoBehaviour
{

    public TMP_InputField input1;
    public Button playButton;
    public TMP_Text highScoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (string.IsNullOrEmpty(input1.text))
        {
            playButton.interactable = false;
        }
        else
        {
            playButton.interactable = true;
        }

        if (PlayerPrefs.GetString("singleHighscore") == "")
        {
            highScoreText.text = "Nikola 46";
        }
        else
        {
            highScoreText.text = PlayerPrefs.GetString("singleHighscore");
        }
    }

    public void playSingleplayer()
    {
        GameManager.isMultiplayerGame = false;
        GameManager.player1Name = input1.text;
        SceneManager.LoadScene("Singleplayer");
    }


}
