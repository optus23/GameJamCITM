using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Readme()
    {
        Application.OpenURL("https://www.citm.upc.edu/");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
