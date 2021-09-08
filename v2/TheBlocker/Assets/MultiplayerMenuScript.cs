using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultiplayerMenuScript : MonoBehaviour
{

    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_Dropdown dropdown;
    public Button playButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (string.IsNullOrEmpty(input1.text) || string.IsNullOrEmpty(input2.text))
        {
            playButton.interactable = false;
        }
        else
        {
            playButton.interactable = true;
        }
    }

    public void playMultiplayer()
    {

        GameManager.isMultiplayerGame = true;
        GameManager.player1Name = input1.text;
        GameManager.player2Name = input2.text;

        

        PlayerPrefs.DeleteAll();

        PlayerPrefs.SetInt("currentRound", 1);

        if (dropdown.value == 0)
        {
            PlayerPrefs.SetInt("numberOfRounds", 2);
        }
        else if (dropdown.value == 1)
        {
            PlayerPrefs.SetInt("numberOfRounds", 6);
        }
        else if (dropdown.value == 2)
        {
            PlayerPrefs.SetInt("numberOfRounds", 10);
        }

        SceneManager.LoadScene("Multiplayer");
    }
}
