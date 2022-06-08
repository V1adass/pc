using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenegerBp : MonoBehaviour
{
    public BASE SpissComp;
    public Button BpClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;
    
    
    public ManagerVideocarta ScriptVidMan;

    private void Start()
    {
        BpClick.onClick.AddListener(OpenBpClik);
        
        
    }
    void OpenBpClik()
    {
        ScrollViev.SetActive(true);
        Clear();
        for (int i = 0; i<= SpissComp.Bp.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);
            
            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabBp>().enabled=true;
            Ikon.GetComponent<PrefabBp>().Bp=SpissComp.Bp[i];
            Ikon.GetComponent<PrefabBp>().InfoPanel=Infopanel;

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
