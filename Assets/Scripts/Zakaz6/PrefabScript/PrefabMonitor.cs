using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabMonitor : MonoBehaviour, IPointerDownHandler
{
    public DataMonitor Monitor;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;


    public void OnPointerDown(PointerEventData eventData)
    {
        TypeIkon="Monitor";
        InfoPanel.GetComponent<PrefabInfoPanel>().Monitor=Monitor;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    private void Start()
    {
        Name.text=$"{Monitor.Name} {Monitor.Matrix} {Monitor.ScreenResolution} ";
        Picte.sprite= Monitor.Image;
    }
}
