using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPlusMinus : MonoBehaviour
{
    //int firstCount = 0;
    public int firstCount = 1;
    public Text firstText;

    DeleteItem deleteItem;
    // Start is called before the first frame update
    void Start()
    {
        //firstCount = 1;
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
        //if (firstCount == 0)
        //{
        //    //Destroy(this.gameObject);
        //}
        if(firstCount>0)
        {
            firstCount--;
            firstText.text = "" + firstCount;
        }
        else
        {
            Destroy(this.gameObject);
        }
        //firstCount--;
        //firstText.text = "" + firstCount;
    }
}
