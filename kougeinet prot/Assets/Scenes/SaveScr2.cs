using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScr2 : MonoBehaviour
{
    List<string> textList = new List<string>();
    List<string> valueList = new List<string>();

    public GameObject itemPrefab;
    public GameObject Content;

    int countClick = 0;
    //string countBox;
    int countSize = 0;
    bool dataFlag = false;

    NameAdd nameAdd;

    // Start is called before the first frame update
    void Start()
    {
        // Loading
        //countSize = PlayerPrefs.GetInt("countSize", 0);
        //for (int i = 0; i < countSize; i++)
        //{
        //    textList.Add(PlayerPrefs.GetString("name" + i, "lol"));
        //    valueList.Add("0");
        //    //Debug.Log(textList[i]);
        //    GameObject itemObj = (GameObject)Instantiate(itemPrefab);
        //    itemObj.transform.Find("Item_Name").gameObject.GetComponent<Text>().text = "" + textList[i];
        //    itemObj.transform.SetParent(Content.transform, false);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddList()
    {
        ////countBox = countClick.ToString();
        ////PlayerPrefs.SetString("" + countBox, ItemGenerator.textIn);
        //textList.Add(ItemGenerator.textIn);////////////////////////////////////////////////////////////////////////////////////
        //valueList.Add("0");
        ////valueList.Add(CountPlusMinus.endCount);
        //Debug.Log(valueList.Count);
        countClick++;
    }

    public void DeleteList()
    {
        ////PlayerPrefs.DeleteKey();
        //textList.Remove(ItemGenerator.textIn);////////////////////////////////////////////////////////////////////////////
        //valueList.Remove("0");
        //Debug.Log("in " + valueList.Count);
        ////intList.Remove(CountPlusMinus.endCount);
    }

    public void DataDeleteButton()
    {
        //Debug.Log("ooooooooo");
        dataFlag = true;
        PlayerPrefs.DeleteAll();
    }
    private void OnApplicationQuit()
    {
        if (dataFlag == false)
        {
            //GameObject[] box = GameObject.FindGameObjectsWithTag("item");
            // 終了時にセーブ
            //PlayerPrefs.SetInt("countSize", valueList.Count);
            //for (int i = 0; i < valueList.Count; i++)
            //{
            //    PlayerPrefs.SetString("name" + i, textList[i]);
            //}
            for (int i = 0; i < countClick; i++)
            {
                //GameObject itemNum = GameObject.Find("" + i);
                //nameAdd = itemNum.GetComponent<NameAdd>();
                //Debug.Log(nameAdd.nameText.text);
            }

        }
        else
        {
            dataFlag = false;
        }
    }
}
