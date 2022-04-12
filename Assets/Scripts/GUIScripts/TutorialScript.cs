using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    [SerializeField] GameObject[] pic;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }
    [SerializeField] GameObject button = null;
    // Update is called once per frame
    void Update()
    {
        if(index >=5)
        {
            index = 5;
            button.SetActive(false);
        }
        if(index <0)
        {
            index = 0;
            button.SetActive(true);
        }

        if(index ==0)
        {
            pic[0].gameObject.SetActive(true);
            button.SetActive(true);
        }

        if(index >0 && index <5)
        {
            button.SetActive(true);
        }
         
    }


    public void Next()
    {

        index += 1;
        for (int i=0; i<=pic.Length-1;i++)
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


}
