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
    public void LoadRewards()
    {
        SceneManager.LoadScene("RewardsScene",LoadSceneMode.Additive);
    }
    public void AddLoading()
    {
        SceneManager.LoadScene("Loading");
    }
    public void ClaimReward()
    {
        SceneManager.LoadScene("ClaimReward");
    }
    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void GameLevel()
    {
        SceneManager.LoadScene("GameLevelScene");
    }
    
}
