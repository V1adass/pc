using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenegerOperativka : MonoBehaviour
{
    [HideInInspector]
    public DataOperativka Operativka;
    public BASE ScriptBase;
    public Button ClickOperativka;
    public Transform Content;
    public GameObject Instatiates;
    public GameObject ScrollViev;

    public GameObject Infopanel;
    public ManagerVideocarta ScriptVidMan;

    void Start()
    {
        ClickOperativka.onClick.AddListener(OpenOperativka);
    }

    // Update is called once per frame

    void OpenOperativka()
    {
        
        ScrollViev.SetActive(true);
        Clear();
        for (int i = 0; i<= ScriptBase.Operativka.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);
            
            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);

            Ikon.GetComponent<PrefabOperativka>().enabled=true;
            Ikon.GetComponent<PrefabOperativka>().Operativka=ScriptBase.Operativka[i];
            Ikon.GetComponent<PrefabOperativka>().InfoPanel=Infopanel;
        }
    }

    void Clear()
    {
        for(int a=0; a<=ScriptVidMan.MassivObj.Length-1; a++)
        {
            Destroy(ScriptVidMan.MassivObj[a]);
        }
    }
}
