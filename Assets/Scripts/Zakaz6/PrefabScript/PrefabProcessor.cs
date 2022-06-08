using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabProcessor : MonoBehaviour, IPointerDownHandler
{
    public DataProcessor Processor;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;
    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Processor";
        InfoPanel.GetComponent<PrefabInfoPanel>().Processor=Processor;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    void Start()
    {
        Name.text=$"{Processor.Name} {Processor.Core} ядра {Processor.Potoc} потока {Processor.Hertz}GHZ {Processor.Socket}";
        Picte.sprite= Processor.Image;
    }
}
