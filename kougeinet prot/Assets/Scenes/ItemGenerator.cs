using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject Content;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ItemGene()
    {
        GameObject itemObj = (GameObject)Instantiate(itemPrefab);

        // スクロールビューにぶら下げる
        itemObj.transform.SetParent(Content.transform, false);

        // 名前の設定
        string name = GameObject.Find("InputField").transform.Find("Text").GetComponent<Text>().text;
        itemObj.GetComponent<ItemBehaviour>().SetName(name);
    }
}

