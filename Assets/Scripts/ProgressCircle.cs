using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressCircle : MonoBehaviour
{
    public Image Progress;
    public GameObject ButtonStart;
    bool On;
    
    void Start()
    {
        On=true;
    }

    public void Update()
    {
        if (On==true)
        {
            Progress.fillAmount += Time.deltaTime * 0.09f;
        }

        if (Progress.fillAmount >= 1)
        {
            ButtonStart.SetActive(false);
            On=false;

        }
    }
}
