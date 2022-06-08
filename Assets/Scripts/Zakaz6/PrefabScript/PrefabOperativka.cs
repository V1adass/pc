using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabOperativka : MonoBehaviour, IPointerDownHandler
{
    public DataOperativka Operativka;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;

    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Operativka";
        InfoPanel.GetComponent<PrefabInfoPanel>().Operativka=Operativka;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    void Start()
    {
        Name.text=$"{Operativka.Name}  {Operativka.FormFactor}  {Operativka.ValueMemory}Gb {Operativka.Hertz}GHZ {Operativka.TypeMemory}";
        Picte.sprite= Operativka.Image;
    }

  
}
