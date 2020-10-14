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
        //itemPrefab = (GameObject)Resources.Load ("Item");
        GameObject scriptOnly = GameObject.Find("ScriptOnly");
        inputNameAdd = scriptOnly.GetComponent<InputNameAdd>();
        //nameAdd = scriptOnly.GetComponent<NameAdd>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ItemGene()
    {
        //GameObject Item = Instantiate(itemPrefab) as GameObject;

        string textBox;
        textBox = inputNameAdd.inputField.text;

        textIn = textBox;

        //NameAdd n = Item.GetComponent<NameAdd>();
        //n.SetName(textBox);
        //n.SetNameTest();
        //Item.transform.position = new Vector2(0.0f, 0.0f);
        //Item.transform.SetParent(Content.transform, false);

        GameObject itemObj = (GameObject)Instantiate(itemPrefab);
        itemObj.name = "" + SaveScript.num;
        SaveScript.num++;
        itemObj.transform.Find("Item_Name").gameObject.GetComponent<Text>().text = "" + textBox;
        itemObj.transform.SetParent(Content.transform, false);
    }
}

