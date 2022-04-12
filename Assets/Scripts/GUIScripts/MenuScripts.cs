using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MenuScripts : MonoBehaviour
{
    [Header("Volume Settings")]
    [SerializeField]TextMeshProUGUI volumeText =null;
    [SerializeField] Slider volimeSlider = null;
    [SerializeField] private GameObject confirmationObject=null;
    [SerializeField] private float deafultvolume = 0.4f;

    [Header("Graphic Settings")]
    [SerializeField] private Slider brightnessSlider = null;
    [SerializeField] private TextMeshProUGUI brightnessText = null;
    [SerializeField] private int defaultSln=4;

    public int mainControllerSen = 4;

    private bool _isFullScreen;
    private float _brightLevel;


    public void SetBrightness(float bright)
    {
        _brightLevel = bright;
        brightnessText.text = bright.ToString("0.0");

    }

    public void setFullScreen(bool isFullScreen)
    {
        _isFullScreen = isFullScreen;
    }

    public void GraphicsApply()
    {
        PlayerPrefs.SetFloat("MasterBrigthbess", _brightLevel);


        PlayerPrefs.SetInt("masterFull", (_isFullScreen ? 1 : 0));
        Screen.fullScreen = _isFullScreen;

    }

    public void SetFull()
    {
        Screen.fullScreen = _isFullScreen;

    }

    public void ExitScdne()
    {
        Application.Quit();
    }

   public  void SetVolume(float Volume)
    {
        AudioListener.volume = Volume;
        volumeText.text = Volume.ToString("0.0");
    }

    public void volumeApply()
    {

        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfrimationBox());

    }

    public void ResetButon(string MenuType)
    {
        if(MenuType=="Audio")
        {
            AudioListener.volume = deafultvolume;
            volimeSlider.value = deafultvolume;
            volumeText.text = deafultvolume.ToString("0.0");
            volumeApply();
        }

        if(MenuType== "Graphics")
        {
            brightnessSlider.value = defaultSln;
            brightnessText.text = defaultSln.ToString("0");
        }
    }

    public IEnumerator ConfrimationBox()
    {
        confirmationObject.SetActive(true);
        yield return new WaitForSeconds(1);
        confirmationObject.SetActive(false);
    }
}
