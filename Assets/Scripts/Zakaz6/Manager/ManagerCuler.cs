using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerCuler : MonoBehaviour
{
    public BASE SpissComp;
    public Button CulPlatClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;

    public ManagerVideocarta ScriptVidMan;
    void Start()
    {
        CulPlatClick.onClick.AddListener(OpenCuller);
    }
    void OpenCuller()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i = 0; i<= SpissComp.Culler.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);
            
            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabCuller>().enabled=true;
            Ikon.GetComponent<PrefabCuller>().Culler=SpissComp.Culler[i];
            Ikon.GetComponent<PrefabCuller>().InfoPanel=Infopanel;

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
