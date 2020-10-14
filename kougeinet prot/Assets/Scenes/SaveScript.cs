using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScript : MonoBehaviour
{
    List<string> textList = new List<string>();
    List<string> valueList = new List<string>();
    List<int> countList = new List<int>();

    public GameObject itemPrefab;
    public GameObject Content;

    int countClick = 0;
    //string countBox;
    int countSize = 0;
    bool dataFlag = false;

    public static int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Loading
        countSize = PlayerPrefs.GetInt("countSize", 0);
        for (int i = 0; i < countSize; i++)
        {
            textList.Add(PlayerPrefs.GetString("name" + i, "lol"));
            valueList.Add("" + i);
            countList.Add(1);
            //Debug.Log(textList[i]);

            GameObject itemObj = (GameObject)Instantiate(itemPrefab);

            itemObj.name = "" + num;
            num++;

            itemObj.transform.Find("Item_Name").gameObject.GetComponent<Text>().text = "" + textList[i];
            itemObj.transform.SetParent(Content.transform, false);

            Debug.Log("now " + valueList.Count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.R))
        //{
        //    Debug.Log("ooooooooo");
        //    PlayerPrefs.DeleteAll();
        //}
    }

    public void AddList()
    {
        //countBox = countClick.ToString();
        //PlayerPrefs.SetString("" + countBox, ItemGenerator.textIn);

        textList.Add(ItemGenerator.textIn);////////////////////////////////////////////////////////////////////////////////////
        valueList.Add("" + num);
        countList.Add(1);

        //valueList.Add(CountPlusMinus.endCount);
        Debug.Log(valueList.Count);
        //countClick++;
    }

    public void DeleteList(string myName)
    {
        //PlayerPrefs.DeleteKey();
        textList.RemoveAt(int.Parse(myName));////////////////////////////////////////////////////////////////////////////
        valueList.Remove("" + myName);
        countList.RemoveAt(int.Parse(myName));
        Debug.Log("in "+ valueList.Count);
        //intList.Remove(CountPlusMinus.endCount);
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
            PlayerPrefs.SetInt("countSize", valueList.Count);
            for (int i = 0; i < valueList.Count; i++)
            {
                PlayerPrefs.SetString("name" + i, textList[i]);
            }

        }
        else
        {
            dataFlag = false;
        }

        //GameObject[] saveBox = GameObject.FindGameObjectsWithTag("item");
        //valueList[0]=saveBox[0].transform.Find("0").gameObject.GetComponent<Text>().text;
        //valueList.Add(saveBox[0].GetComponent<Text>());
        //Debug.Log(valueList[0]);
        //PlayerPrefs.SetString("name" + 0, saveBox[0]);
    }


}
