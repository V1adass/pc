using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabCuller : MonoBehaviour, IPointerDownHandler
{
    public DataCuller Culler;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;

    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Culler";
        InfoPanel.GetComponent<PrefabInfoPanel>().Culer=Culler;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    void Start()
    {
        Name.text=$"{Culler.Name} {Culler.Speed} {Culler.Power}V ";
        Picte.sprite= Culler.Image;
    }

    
   
}
