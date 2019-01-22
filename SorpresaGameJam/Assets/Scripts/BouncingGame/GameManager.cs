using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject ui;

    void Start()
    {
        ui.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        ui.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("BouncingGame");
        Time.timeScale = 1.0f;
    }

    public void Return()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }
}
