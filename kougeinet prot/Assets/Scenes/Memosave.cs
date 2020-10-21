using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memosave : MonoBehaviour
{
    public InputField inputField;
    // public static Text text;
    public string memo;
    string myName;
    //SaveScript saveScript;
    SaveScript saveScript;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject scriptOnly = GameObject.Find("ScriptOnly");
        //saveScript = scriptOnly.GetComponent<SaveScript>();
        //GameObject scriptOnly = GameObject.Find("ScriptOnly");
        //saveScript = scriptOnly.GetComponent<SaveScript>();
        //saveScript = GameObject.Find("ScriptOnly").GetComponent<SaveScript>();

        inputField.text = gameObject.transform.Find("memo").gameObject.GetComponent<InputField>().text;

        myName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        //memo = inputField.text;
    }

    public void Memos()
    {
        saveScript = GameObject.Find("ScriptOnly").GetComponent<SaveScript>();
        myName = gameObject.name;
        memo = inputField.text;
        Debug.Log(myName + ":::::"+memo);
        saveScript.ChangeMemo(myName, memo);
        //saveScript.GetComponent<SaveScript>().ChangeMemo(myName);
    }
}
