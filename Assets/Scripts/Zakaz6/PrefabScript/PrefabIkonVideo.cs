using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabIkonVideo : MonoBehaviour, IPointerDownHandler
{
    public DataVideocarta Videocarta;

    public Text Name;
    public Image Picte;
    [HideInInspector]
    public GameObject InfoPanel;

    public string TypeIkon;

    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Videocarta";
        InfoPanel.GetComponent<PrefabInfoPanel>().Videocarta=Videocarta;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);    
    }

    void Start()
    {
        Name.text=$"{Videocarta.Name} {Videocarta.TypeMemory} {Videocarta.VideoConnectors} {Videocarta.VideoMemory}GB {Videocarta.—onnection—onnector}";
        Picte.sprite= Videocarta.Image;
    }

    
}
