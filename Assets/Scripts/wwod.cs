using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wwod : MonoBehaviour
{
    [SerializeField] private Text GlavText;
    [SerializeField] private Text InputText;
    [SerializeField] private InputField InputField;
    [SerializeField] private string OutputText;

    public void SaveInputText()
    {
        OutputText = InputText.text;
        ShowText();

    }
    public void ShowText()
    {
        GlavText.text = OutputText;
    }
}
