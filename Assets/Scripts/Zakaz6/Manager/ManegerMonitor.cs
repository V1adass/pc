using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManegerMonitor : MonoBehaviour
{
    // Start is called before the first frame update
    public BASE SpissComp;
    public Button MonitorClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;

    public ManagerVideocarta ScriptVidMan;

    void Start()
    {
        MonitorClick.onClick.AddListener(OpenMonitor);
    }

    void OpenMonitor()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i = 0; i<= SpissComp.Keyboard.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);

            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabMonitor>().enabled=true;
            Ikon.GetComponent<PrefabMonitor>().Monitor=SpissComp.Monitor[i];
            Ikon.GetComponent<PrefabMonitor>().InfoPanel=Infopanel;

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
