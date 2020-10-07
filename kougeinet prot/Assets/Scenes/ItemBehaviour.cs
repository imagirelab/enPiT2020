using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    string stuff_name = "";
    int stuff_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplayedStuffNumber();// 表示の更新
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 名前管理
    public void SetName(string name)
    {
        stuff_name = name;

        // Item_Nameに反映
        this.gameObject.transform.Find("Item_Name").gameObject.GetComponent<Text>().text = "" + name;
    }

    // 数量管理
    void UpdateDisplayedStuffNumber()
    {
        this.gameObject.transform.Find("Item_Value").gameObject.GetComponent<Text>().text = "" + stuff_count;
    }

    public void IncrementStuff()
    {
        stuff_count++;
        UpdateDisplayedStuffNumber();
    }

    public void DecrementStuff()
    {
        // 0で押されたら自殺
        if(stuff_count <= 0)
        {
            Destroy(this.gameObject);
            return;
        }

        stuff_count--;

        UpdateDisplayedStuffNumber();
    }

}
