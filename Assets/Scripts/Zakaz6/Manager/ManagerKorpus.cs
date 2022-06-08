using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerKorpus : MonoBehaviour
{
    public BASE SpissComp;
    public Button CorpusClick;
    public Transform Content;
    public GameObject Instatiates;

    public GameObject ScrollViev;

    public GameObject Infopanel;


    public ManagerVideocarta ScriptVidMan;
    void Start()
    {
        CorpusClick.onClick.AddListener(OpenSSDClik);
    }

    void OpenSSDClik()
    {
        Clear();
        ScrollViev.SetActive(true);
        for (int i = 0; i<= SpissComp.Corpus.Length-1; i++)
        {
            GameObject Ikon = Instantiate(Instatiates);

            ScriptVidMan.MassivObj[i]=Ikon;
            Ikon.transform.SetParent(Content);
            Ikon.GetComponent<PrefabCorpus>().enabled=true;
            Ikon.GetComponent<PrefabCorpus>().Corpus=SpissComp.Corpus[i];
            Ikon.GetComponent<PrefabCorpus>().InfoPanel=Infopanel;

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
