using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starts : MonoBehaviour
{
    public Button Starting;
    public Image Bar;
    public GameObject FonBar;
    public GameObject Phon;
    public GameObject OldFon;
    
    bool St;
    void Start()
    {
        Starting.onClick.AddListener(ClickStart);
    }

   void ClickStart()
    {
        St=true;
        Phon.SetActive(true);
        OldFon.SetActive(false);
    }

    private void Update()
    {
        if (St==true)
        {
            Bar.fillAmount+=0.005f;
        }
        if (Bar.fillAmount>=1)
        {
            St=false;
            FonBar.SetActive(false);
        }
        
    }
}
