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
    public InputField firstText2;

    DeleteItem deleteItem;
    SaveScript saveScript;

    string myName;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scriptOnly = GameObject.Find("ScriptOnly");
        saveScript = scriptOnly.GetComponent<SaveScript>();
        //firstCount = 1;

        //firstCount = int.Parse(firstText.text);
        firstCount = int.Parse(gameObject.transform.Find("Item_Value2").gameObject.GetComponent<InputField>().text);

        //Debug.Log("bbbbbbbbbbb" + firstCount);
        //firstText.text = "" + firstCount;
        //Debug.Log("aaaaaaaaaaa"+firstCount);
        endCount = firstCount;

        myName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValueChange()
    {
        saveScript = GameObject.Find("ScriptOnly").GetComponent<SaveScript>();
        myName = gameObject.name;

        firstCount = int.Parse(firstText2.text);
        endCount = firstCount;
        firstText2.text = "" + firstCount;
        saveScript.ChangeCount(myName);
    }

    public void ClickPlusButton()
    {
        firstCount++;
        endCount = firstCount;
        //firstText.text = "" + firstCount;
        firstText2.text = "" + firstCount;

        // valueを入れる
        //myName = gameObject.name;
        //Debug.Log("[[[" + myName);
        saveScript.ChangeCount(myName);
    }

    public void ClickMinusButton()
    {
        //if (firstCount == 0)
        //{
        //    //Destroy(this.gameObject);
        //}

        // valueを入れる
        //myName = gameObject.name;
        //Debug.Log("[[[" + myName);
        saveScript.ChangeCount(myName);

        if (firstCount > 0)
        {
            firstCount--;
            endCount = firstCount;
            //firstText.text = "" + firstCount;
            firstText2.text = "" + firstCount;
            saveScript.ChangeCount(myName);
        }
        else
        {
            firstCount--;
            endCount = firstCount;
            myName = gameObject.name;
            //Debug.Log("////////" + myName + "///////");
            saveScript.ChangeCount(myName);
            //saveScript.DeleteList(myName);
            Destroy(this.gameObject);
        }
        //firstCount--;
        //firstText.text = "" + firstCount;
    }

    //public void SetStart()
    //{
    //    firstCount = endCount;
    //}
    //public void CountSet()
    //{
    //    int i = int.Parse(myName);
    //    firstCount = saveScript.ValueReturn(i);
    //}
}
