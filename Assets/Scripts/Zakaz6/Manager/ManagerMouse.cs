using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerMouse : MonoBehaviour
{
    public BASE SpissComp;
    public Button MouseClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;

    public ManagerVideocarta ScriptVidMan;
    void Start()
    {
        MouseClick.onClick.AddListener(OpenMouse);
    }

    void OpenMouse()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i = 0; i<= SpissComp.Mouse.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);

            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabMouse>().enabled=true;
            Ikon.GetComponent<PrefabMouse>().Mouse=SpissComp.Mouse[i];
            Ikon.GetComponent<PrefabMouse>().InfoPanel=Infopanel;

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
