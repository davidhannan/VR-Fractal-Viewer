using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlGens : MonoBehaviour
{
    public GameObject Sliders;

    public GameObject[] sliders = new GameObject[10];
    public int nowNum;
    public int numSliders;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            sliders[i] = Sliders.transform.GetChild(i).gameObject;
        }
        nowNum = 1;
    }

    public void changeSliders(System.Single num)
    {
        numSliders = (int)num;
        text.text = num.ToString();
        if(nowNum < numSliders)
        {
            
            sliders[nowNum].SetActive(true);
            nowNum = numSliders;
            
        }
        if (nowNum >= numSliders )
        {
            nowNum = numSliders;
            sliders[nowNum].SetActive(false);
            


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
