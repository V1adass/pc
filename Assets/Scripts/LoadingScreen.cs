using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public string loadLevel;
    public GameObject loadingScreen;
    public Slider ProgressBar;
    public GameObject TextKeyDown;

    public void Load()
    {
        loadingScreen.SetActive(true);
        //SceneManager.LoadScene(loadLevel);

    }
    public void Update()
    {
        ProgressBar.value += Time.deltaTime * 0.07f;
        if (ProgressBar.value == 1) 
        {
            TextKeyDown.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
              SceneManager.LoadScene(loadLevel);
            }
        }
    }
}