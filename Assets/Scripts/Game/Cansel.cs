using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cansel : MonoBehaviour
{

    public Button ButtonCancelPochta;
    public GameObject ObjPhon;
    
    void Start()
    {
        ButtonCancelPochta.onClick.AddListener(Cansel1);
    }

   void Cansel1()
    {
        ObjPhon.SetActive(false);
    }
}
