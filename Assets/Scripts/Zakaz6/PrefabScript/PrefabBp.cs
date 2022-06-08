using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabBp : MonoBehaviour, IPointerDownHandler
{
    public DataBp Bp;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;

    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Bp";
        InfoPanel.GetComponent<PrefabInfoPanel>().Bp=Bp;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    private void Start()
    {
        Name.text=$"{Bp.Name} {Bp.FormFactor} {Bp.Power}V ";
        Picte.sprite= Bp.Image;
    }

}
