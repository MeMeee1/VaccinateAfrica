using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LoadPref : MonoBehaviour
{
    [Header("Graphic Settings")]
    [SerializeField] private TextMeshProUGUI brightNessText = null;
    [SerializeField] private Slider brightSlide = null;
    [Header("Full Screen")]
    [SerializeField] Toggle toggle;
    [Header("VOlume Settings")]
    [SerializeField] private TextMeshProUGUI volumeText = null;
    [SerializeField] private Slider volumeSlide = null;

    public bool canuse;
    MenuScripts scripts;
    private void Awake()
    {
        if (canuse == true)
        {
            if (PlayerPrefs.HasKey("MasterBrigthbess"))
            {
                float localBright = PlayerPrefs.GetFloat("MasterBrigthbess");
                brightNessText.text = localBright.ToString("0.0");
                brightSlide.value = localBright;
               
            }



            else
            {
                scripts.ResetButon("Audio");
            }


            if (PlayerPrefs.HasKey("masterVolume"))
            {
                float localVolme = PlayerPrefs.GetFloat("masterVolume");
                volumeText.text = localVolme.ToString("0.0");
                volumeSlide.value = localVolme;
                AudioListener.volume = localVolme;
            }



            else
            {
                scripts.ResetButon("Audio");
            }


            if (PlayerPrefs.HasKey("masterFull"))
            {
                int localFull = PlayerPrefs.GetInt("masterFull");
                if (localFull == 1)
                {
                    Screen.fullScreen = true;
                    toggle.isOn = true;
                }

                else
                {
                    Screen.fullScreen = false;
                    toggle.isOn = false;
                }


               
            }

        }
    }
}
