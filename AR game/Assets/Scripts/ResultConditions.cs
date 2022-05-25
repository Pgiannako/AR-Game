using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultConditions : MonoBehaviour
{
    private bool gameEnd;
    public GameObject winUI;
    public GameObject loseUI;
    private int ballCounter = 0;

    public void Initialise()
    {
        winUI.SetActive(false);
        loseUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


    public void WinCondition()
    {
        if (!gameEnd)
        {
            name = SceneManager.GetActiveScene().name;
            if (name == "biliard table 5") // unique win condition for scene 5
            {
                ballCounter += 1;
                if(ballCounter == 4)
                {
                    winUI.SetActive(true);
                    Debug.Log("win");
                    gameEnd = true;
                    StartCoroutine(nextScene());
                }
            }
            else if(name == "biliard table 6")  // unique win condition for scene 6
            {
                ballCounter += 1;
                if (ballCounter == 6)
                {
                    winUI.SetActive(true);
                    Debug.Log("win");
                    gameEnd = true;
                    StartCoroutine(nextScene());
                }
            }
            else  // generic win condition
            {
                winUI.SetActive(true);
                Debug.Log("win");
                gameEnd = true;
                StartCoroutine(nextScene());
            } 
        }
    }

    public void LoseCondition()
    {
        if (!gameEnd)
        {
            loseUI.SetActive(true); 
            Debug.Log("lose");
            gameEnd = true;
            scoring.totalDeaths += 1;
            StartCoroutine(reset());
        }        
    }

    IEnumerator reset()
    {
        yield return new WaitForSecondsRealtime(3);  // wait 3 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSecondsRealtime(3);  // wait 3 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);  // TODO add a way to figure when we reach the last scene
    }
}
