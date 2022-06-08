using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Zadanie : MonoBehaviour
{

    public GameObject PanelZadanie;
    public InputField InputText;
    public Button Ok;
    public Button OpenZadanie;

    private void Start()
    {
        Ok.onClick.AddListener(ZadanieSave);
        OpenZadanie.onClick.AddListener(OpenZadanies);
    }

    void ZadanieSave()
    {
        PlayerPrefs.SetString("Zadanie", InputText.text);
        PanelZadanie.SetActive(false);
        SceneManager.LoadScene("BildComp1");
    }
    void OpenZadanies()
    {
        PanelZadanie.SetActive(true);
        
    }


}
