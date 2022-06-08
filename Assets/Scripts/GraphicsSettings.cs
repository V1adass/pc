using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GraphicsSettings : MonoBehaviour
{
   public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
