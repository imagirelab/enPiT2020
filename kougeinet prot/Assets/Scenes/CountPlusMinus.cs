using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPlusMinus : MonoBehaviour
{
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

        firstCount = int.Parse(gameObject.transform.Find("Item_Value2").gameObject.GetComponent<InputField>().text);

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
        firstText2.text = "" + firstCount;

        // valueを入れる
        saveScript.ChangeCount(myName);
    }

    public void ClickMinusButton()
    {
        // valueを入れる
        saveScript.ChangeCount(myName);

        if (firstCount > 0)
        {
            firstCount--;
            endCount = firstCount;
            firstText2.text = "" + firstCount;
            saveScript.ChangeCount(myName);
        }
        else
        {
            firstCount--;
            endCount = firstCount;
            myName = gameObject.name;
            saveScript.ChangeCount(myName);
            Destroy(this.gameObject);
        }
    }
}
