using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int[] player1Score = new int[5] { 0, 0, 0, 0, 0 };
    public int[] player2Score = new int[5] { 0, 0, 0, 0, 0 };
    public static bool isMultiplayerGame;
    public int numberOfRounds;
    public static string player1Name = "TESTING";
    public static string player2Name = "TESTING";
    public int currentRound;


    public TMP_Text player1NameText;
    public TMP_Text player1round1;
    public TMP_Text player1round2;
    public TMP_Text player1round3;
    public TMP_Text player1round4;
    public TMP_Text player1round5;

    public TMP_Text player2NameText;
    public TMP_Text player2round1;
    public TMP_Text player2round2;
    public TMP_Text player2round3;
    public TMP_Text player2round4;
    public TMP_Text player2round5;

    public TMP_Text winnerText;


    private void Start()
    {
        

        

    }

    private void Update()
    {

        if (isMultiplayerGame)
        {
            multiplay();
        }

        


    }

    void multiplay()
    {
        player1NameText.text = player1Name;
        player2NameText.text = player2Name;

        currentRound = PlayerPrefs.GetInt("currentRound");
        numberOfRounds = PlayerPrefs.GetInt("numberOfRounds");

        if (currentRound > 0 && currentRound % 2 == 1)
        {
            player1NameText.color = Color.green;
            player2NameText.color = Color.white;
        }
        else if (currentRound > 0 && currentRound % 2 == 0)
        {
            player1NameText.color = Color.white;
            player2NameText.color = Color.green;
        }

        if (numberOfRounds == 2)
        {
            player1round1.text = "" + PlayerPrefs.GetInt("1");
            player2round1.text = "" + PlayerPrefs.GetInt("2");
        }
        else if (numberOfRounds == 6)
        {
            player1round1.text = "" + PlayerPrefs.GetInt("1");
            player2round1.text = "" + PlayerPrefs.GetInt("2");

            player1round2.text = "" + PlayerPrefs.GetInt("3");
            player2round2.text = "" + PlayerPrefs.GetInt("4");

            player1round3.text = "" + PlayerPrefs.GetInt("5");
            player2round3.text = "" + PlayerPrefs.GetInt("6");
        }
        else if (numberOfRounds == 10)
        {
            player1round1.text = "" + PlayerPrefs.GetInt("1");
            player2round1.text = "" + PlayerPrefs.GetInt("2");

            player1round2.text = "" + PlayerPrefs.GetInt("3");
            player2round2.text = "" + PlayerPrefs.GetInt("4");

            player1round3.text = "" + PlayerPrefs.GetInt("5");
            player2round3.text = "" + PlayerPrefs.GetInt("6");

            player1round4.text = "" + PlayerPrefs.GetInt("7");
            player2round4.text = "" + PlayerPrefs.GetInt("8");

            player1round5.text = "" + PlayerPrefs.GetInt("9");
            player2round5.text = "" + PlayerPrefs.GetInt("10");
        }
    }


    public void EndGame(){

        int scoress = TextScript.score;
        if (isMultiplayerGame)
        {


            
            PlayerPrefs.SetInt("" + PlayerPrefs.GetInt("currentRound"), scoress);
            PlayerPrefs.SetInt("currentRound", PlayerPrefs.GetInt("currentRound") + 1);


            if (PlayerPrefs.GetInt("currentRound") > numberOfRounds)
            {
                int player1points = PlayerPrefs.GetInt("1")
                    + PlayerPrefs.GetInt("3")
                    + PlayerPrefs.GetInt("5")
                    + PlayerPrefs.GetInt("7")
                    + PlayerPrefs.GetInt("9");

                int player2points = PlayerPrefs.GetInt("2")
                    + PlayerPrefs.GetInt("4")
                    + PlayerPrefs.GetInt("6")
                    + PlayerPrefs.GetInt("8")
                    + PlayerPrefs.GetInt("10");

                if (player1points > player2points)
                {
                    winnerText.text = "Winner is player 1 with: " + player1points + " points";
                }
                else if (player1points < player2points)
                {
                    winnerText.text = "Winner is player 2 with: " + player2points + " points";
                }
                else
                {
                    winnerText.text = "There is no winner. Play again.";
                }
                StartCoroutine(wait5());
                wait5();
                
                return;
            }
        }
        else
        {
            PlayerPrefs.SetString("singleHighscore", player1Name + " " + scoress);
        }

        StartCoroutine(ExampleCoroutine());

    }

    IEnumerator wait5()
    {


        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("MainMenu");
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }


    IEnumerator ExampleCoroutine()
    {

        
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSecondsRealtime(4);
        
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

}
