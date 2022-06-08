using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerKeyboard : MonoBehaviour
{
    public BASE SpissComp;
    public Button KeyboardClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;

    public ManagerVideocarta ScriptVidMan;
    void Start()
    {
        KeyboardClick.onClick.AddListener(OpenKeyboard);
    }

    void OpenKeyboard()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i = 0; i<= SpissComp.Monitor.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);

            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabKetboard>().enabled=true;
            Ikon.GetComponent<PrefabKetboard>().Keyboard=SpissComp.Keyboard[i];
            Ikon.GetComponent<PrefabKetboard>().InfoPanel=Infopanel;

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
