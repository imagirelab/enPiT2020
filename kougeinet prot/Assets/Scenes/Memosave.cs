using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memosave : MonoBehaviour
{
    public InputField inputField;
    public string memo;
    string myName;
    SaveScript saveScript;

    // Start is called before the first frame update
    void Start()
    {
        inputField.text = gameObject.transform.Find("memo").gameObject.GetComponent<InputField>().text;

        myName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Memos()
    {
        saveScript = GameObject.Find("ScriptOnly").GetComponent<SaveScript>();
        myName = gameObject.name;
        memo = inputField.text;
        saveScript.ChangeMemo(myName, memo);
    }
}
