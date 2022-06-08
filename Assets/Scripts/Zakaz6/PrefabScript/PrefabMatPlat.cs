using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabMatPlat : MonoBehaviour, IPointerDownHandler
{
    public DataMatPlat MatPlat;
    [HideInInspector]
    public GameObject InfoPanel;

    public Text Name;
    public Image Picte;

    public string TypeIkon;


    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        TypeIkon="MatPlat";
        InfoPanel.GetComponent<PrefabInfoPanel>().MatPlat=MatPlat;
        InfoPanel.GetComponent<PrefabInfoPanel>().ConnecttypeIkon=TypeIkon;
        InfoPanel.SetActive(true);
    }
    private void Start()
    {
        Name.text=$"{MatPlat.Name} {MatPlat.FormFactor} {MatPlat.power}V {MatPlat.Version} {MatPlat.VolueMemory}Gb {MatPlat.VideoConection[0]}  {MatPlat.VideoConection[1]}  {MatPlat.VideoConection[2]}  {MatPlat.VideoConection[3]} ";
        Picte.sprite= MatPlat.Image;
    }

}
