using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabMouse : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    public DataMouse Mouse;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;


    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Mouse";
        InfoPanel.GetComponent<PrefabInfoPanel>().Mouse=Mouse;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    private void Start()
    {
        Name.text=$"{Mouse.Name} {Mouse.TypeConnection} {Mouse.InterfaceConnection} ";
        Picte.sprite= Mouse.Image;
    }
}
