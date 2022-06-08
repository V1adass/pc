using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanselPanelEror : MonoBehaviour
{
    public Button CanselErorPanel;
    public GameObject Panel;
    void Start()
    {
        CanselErorPanel.onClick.AddListener(SancelErorPanel);
    }

    void SancelErorPanel()
    {
        Panel.SetActive(false);
    }
}
