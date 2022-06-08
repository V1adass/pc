using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerVideocarta : MonoBehaviour
{
    public BASE SpissComp;
    public Button VideoClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;
    [HideInInspector]
    public GameObject[] MassivObj;

    public Button Sborka;
    public GameObject Sbor;
    bool OnOf;
    private void Start()
    {
        VideoClick.onClick.AddListener(OpenVideoCard);
        MassivObj= new GameObject[100];
        Sborka.onClick.AddListener(OpenListSborka);
    }

    void OpenVideoCard()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i=0; i<= SpissComp.Videocarta.Length-1; i++)
        {
            GameObject Ikon=Instantiate(Instatiates);
            
            MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);           
            Ikon.GetComponent<PrefabIkonVideo>().enabled=true;
            Ikon.GetComponent<PrefabIkonVideo>().Videocarta=SpissComp.Videocarta[i];
            Ikon.GetComponent<PrefabIkonVideo>().InfoPanel=Infopanel;
            
        }
    }
    void OpenListSborka()
    {
        
        Sbor.SetActive(true);
    }
    void Clear()
    {
        for (int a = 0; a<=MassivObj.Length-1; a++)
        {
            Destroy(MassivObj[a]);
        }
    }
}
