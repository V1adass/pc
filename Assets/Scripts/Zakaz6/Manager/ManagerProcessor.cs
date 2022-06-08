using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerProcessor : MonoBehaviour
{
    [HideInInspector]
    public DataProcessor Processor;
    public BASE ScriptBase;
    public Button ClickProcessor;
    public Transform Content;
    public GameObject Instatiates;
    public GameObject ScrollViev;

    public GameObject Infopanel;
    public ManagerVideocarta ScriptVidMan;


    private void Start()
    {
        ClickProcessor.onClick.AddListener(OpenProcessor);
        
    }
    void OpenProcessor()
    {

        ScrollViev.SetActive(true);
        Clear();
        for (int i = 0; i<= ScriptBase.Processor.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);
           
            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabProcessor>().enabled=true;
            Ikon.GetComponent<PrefabProcessor>().Processor=ScriptBase.Processor[i];
            Ikon.GetComponent<PrefabProcessor>().InfoPanel=Infopanel;

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


