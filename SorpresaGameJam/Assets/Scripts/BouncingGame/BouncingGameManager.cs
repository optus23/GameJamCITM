using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BouncingGameManager : MonoBehaviour {

    Timer countDown;
    public GameObject gameOverMenu;
    public GameObject returnButton;
    public Text TimerText;

    void Start()
    {
        countDown = new Timer();
        countDown.StarTimer();
        countDown.SetCountDown(41.0f);
        gameOverMenu.SetActive(false);
    }

    private void Update()
    {
        int time = (int)countDown.GetCurrentTime();

        if (time < 10)
        {
            TimerText.text = "00:0" + time.ToString();
        }
        else
        {
            TimerText.text = "00:" + time.ToString();
        }

        if (countDown.IsFinalFrame())
        {
            GameWon();
        }
    }

    public void GameWon()
    {
        Time.timeScale = 0f;
        returnButton.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverMenu.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("BouncingGame");
    }

    public void Return()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void OnDestroy()
    {
        Time.timeScale = 1.0f;
    }
}
