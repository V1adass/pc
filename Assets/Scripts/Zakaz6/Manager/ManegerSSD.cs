using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManegerSSD : MonoBehaviour
{
    public BASE SpissComp;
    public Button SSDClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;


    public ManagerVideocarta ScriptVidMan;

    void Start()
    {
        SSDClick.onClick.AddListener(OpenSSDClik);
    }

    void OpenSSDClik()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i = 0; i<= SpissComp.SSD.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);
            
            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabSSD>().enabled=true;
            Ikon.GetComponent<PrefabSSD>().SSD=SpissComp.SSD[i];
            Ikon.GetComponent<PrefabSSD>().InfoPanel=Infopanel;

        }
    }
    void Clear()
    {
        for (int a = 0; a<=ScriptVidMan.MassivObj.Length-1; a++)
        {
            Destroy(ScriptVidMan.MassivObj[a]);
        }
    }

}
