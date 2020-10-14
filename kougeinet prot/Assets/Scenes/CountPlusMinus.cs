using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPlusMinus : MonoBehaviour
{
    //int firstCount = 0;
    public static int endCount = 0;
    public int firstCount = 1;
    public Text firstText;

    DeleteItem deleteItem;
    SaveScript saveScript;

    string myName;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scriptOnly = GameObject.Find("ScriptOnly");
        saveScript = scriptOnly.GetComponent<SaveScript>();
        //firstCount = 1;
        firstText.text = "" + firstCount;
        endCount = firstCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickPlusButton()
    {
        firstCount++;
        endCount = firstCount;
        firstText.text = "" + firstCount;

        // valueを入れる
    }

    public void ClickMinusButton()
    {
        //if (firstCount == 0)
        //{
        //    //Destroy(this.gameObject);
        //}

        // valueを入れる

        if(firstCount>0)
        {
            firstCount--;
            endCount = firstCount;
            firstText.text = "" + firstCount;
        }
        else
        {
            myName = gameObject.name;
            //Debug.Log("////////" + myName + "///////");

            saveScript.DeleteList(myName);
            Destroy(this.gameObject);
        }
        //firstCount--;
        //firstText.text = "" + firstCount;
    }
}
