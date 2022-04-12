using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    private static TutorialManager instance;
    public GameObject startTutorial;
    public GameObject skipTutorial;
    public static bool isGold;
    
    public int _tut = 100;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        isGold = false;
        if(isGold = true)
        {
            Debug.Log("YEp");
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddTut()
    {
        _tut = 100;
    }
    public void StartNow()
    {
        startTutorial.SetActive(true);
        skipTutorial.SetActive(false);
        isGold = true;
    }
    public void SkipNow()
    {
        startTutorial.SetActive(false);
        skipTutorial.SetActive(false);
        SceneManager.LoadScene("GameScene");
        isGold=true;
    }
}
