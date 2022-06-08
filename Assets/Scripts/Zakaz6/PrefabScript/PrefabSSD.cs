using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabSSD : MonoBehaviour, IPointerDownHandler
{
    public DataSSD SSD;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;

    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="SSD";
        InfoPanel.GetComponent<PrefabInfoPanel>().SSD=SSD;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }

    void Start()
    {
        Name.text=$"{SSD.Name} {SSD.FormFactor} {SSD.Power}V {SSD.SpeedReed}mb/sec";
        Picte.sprite= SSD.Image;
    }


}
