using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptZadanie : MonoBehaviour
{
    public Text Zadan;
    void Start()
    {
        Zadan.text=PlayerPrefs.GetString("Zadanie");
    }

    
}
