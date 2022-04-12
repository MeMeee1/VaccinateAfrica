using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingTheScene : MonoBehaviour
{
    [SerializeField] int screenNumber;
    public void LoadingScene()
    {
        SceneManager.LoadScene(screenNumber);
    }
}
