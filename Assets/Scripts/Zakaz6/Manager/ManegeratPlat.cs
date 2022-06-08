using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManegeratPlat : MonoBehaviour
{
    public BASE SpissComp;
    public Button MatPlatClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;

    public ManagerVideocarta ScriptVidMan;


    void Start()
    {
        MatPlatClick.onClick.AddListener(OpenMatPlat);
    }

    void OpenMatPlat()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i = 0; i<= SpissComp.MatPlat.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);
            
            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabMatPlat>().enabled=true;
            Ikon.GetComponent<PrefabMatPlat>().MatPlat=SpissComp.MatPlat[i];
            Ikon.GetComponent<PrefabMatPlat>().InfoPanel=Infopanel;

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
