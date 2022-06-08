using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabCorpus : MonoBehaviour, IPointerDownHandler
{
    public DataCorpus Corpus;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;
    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Corpus";
        InfoPanel.GetComponent<PrefabInfoPanel>().Corpus=Corpus;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    void Start()
    {
        Name.text=$"{Corpus.Name} {Corpus.FormFactor} {Corpus.Length}mm {Corpus.Width}mm {Corpus.Height}mm ";
        Picte.sprite= Corpus.Image;
    }
}
