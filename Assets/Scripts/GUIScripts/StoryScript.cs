using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScript : MonoBehaviour
{
    [SerializeField] GameObject[] pic;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(index >=7)
        {
            index = 6;
        }
        if(index <0)
        {
            index = 0;
        }

        if(index ==0)
        {
            pic[0].gameObject.SetActive(true);
        }
         
    }


    public void Forward()
    {

        index += 1;
        for (int i=0; i<pic.Length;i++)
        {

            pic[i].gameObject.SetActive(false);
            pic[index].gameObject.SetActive(true);
        }

    }
    public void Back()
    {

        index -= 1;
        for (int i = 0; i < pic.Length; i++)
        {

            pic[i].gameObject.SetActive(false);
            pic[index].gameObject.SetActive(true);
        }

    }
    public void ShowMain()
    {
        SceneManager.LoadScene("MainScene");
    }
    
}
