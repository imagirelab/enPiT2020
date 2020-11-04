using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject Content;

    public static string textIn;

    InputNameAdd inputNameAdd;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scriptOnly = GameObject.Find("ScriptOnly");
        inputNameAdd = scriptOnly.GetComponent<InputNameAdd>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ItemGene()
    {
        string textBox;
        textBox = inputNameAdd.inputField.text;

        textIn = textBox;

        GameObject itemObj = (GameObject)Instantiate(itemPrefab);
        itemObj.name = "" + SaveScript.num;
        SaveScript.num++;
        itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = ColorChangeScript.nowColor;
        itemObj.transform.Find("Item_Name").gameObject.GetComponent<Text>().text = "" + textBox;
        itemObj.transform.SetParent(Content.transform, false);
    }
}

