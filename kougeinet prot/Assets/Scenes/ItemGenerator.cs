using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject Content;

    NameAdd nameAdd;
    // Start is called before the first frame update
    void Start()
    {
        //itemPrefab = (GameObject)Resources.Load ("Item");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ItemGene(Text text)
    {
        GameObject Item = Instantiate(itemPrefab) as GameObject;

        //nameAdd.NameAddClick();
        NameAdd n = Item.GetComponent<NameAdd>();
        n.SetName(text);

        Item.transform.position = new Vector2(0.0f, 0.0f);

        Item.transform.SetParent(Content.transform, false);
    }
}

