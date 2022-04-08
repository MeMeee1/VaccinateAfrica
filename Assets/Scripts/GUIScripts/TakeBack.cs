using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TakeBack : MonoBehaviour
{
    [SerializeField]string sceneName;
    public void notAvailable()
    {
        SceneManager.LoadScene(sceneName);
    }
}
