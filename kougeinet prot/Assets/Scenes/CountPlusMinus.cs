using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPlusMinus : MonoBehaviour
{
    //int firstCount = 0;
    int firstCount = 1;
    public Text firstText;
    // Start is called before the first frame update
    void Start()
    {
        firstText.text = "" + firstCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickPlusButton()
    {
        firstCount++;
        firstText.text = "" + firstCount;
    }

    public void ClickMinusButton()
    {
        if(firstCount>0)
        {
            firstCount--;
            firstText.text = "" + firstCount;
        }
    }
}
