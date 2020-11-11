using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameAdd : MonoBehaviour
{
    public InputField inputField;
    public string itemname;
    string myName;
    SaveScript saveScript;

    void Start()
    {
        inputField.text = gameObject.transform.Find("Item_Name").gameObject.GetComponent<InputField>().text;

        myName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ItemNames()
    {
        saveScript = GameObject.Find("ScriptOnly").GetComponent<SaveScript>();
        myName = gameObject.name;
        itemname = inputField.text;
        saveScript.ChangeName(myName, itemname);
    }
}
