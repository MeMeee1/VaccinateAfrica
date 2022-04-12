using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject showAchievement;
    
    public void PlayScene()
    {
        SceneManager.LoadScene("InfroScene");
    }
    public void QuitScene()
    {
        Application.Quit();
    }
    public void ShowAchievement()
    {
        showAchievement.SetActive(true);
    }
    public void CloseAchievement()
    {
        showAchievement.SetActive(false);
    }
    public void GoHome()
    {
        SceneManager.LoadScene("MainScene");
    }
    
}
