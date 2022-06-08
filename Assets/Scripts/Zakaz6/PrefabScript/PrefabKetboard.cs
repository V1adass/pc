using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabKetboard : MonoBehaviour, IPointerDownHandler
{
    public DataKeyboard Keyboard;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;


    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Keyboard";
        InfoPanel.GetComponent<PrefabInfoPanel>().Keyboard=Keyboard;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    private void Start()
    {
        Name.text=$"{Keyboard.Name} {Keyboard.InterfaceConnector} {Keyboard.TypeConnector} ";
        Picte.sprite= Keyboard.Image;
    }
}
