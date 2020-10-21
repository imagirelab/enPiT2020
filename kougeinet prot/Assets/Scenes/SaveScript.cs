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
    List<string> memoList = new List<string>();

    public GameObject itemPrefab;
    public GameObject Content;

    int countClick = 0;
    //string countBox;
    int countSize = 0;
    bool dataFlag = false;

    public static int num = 0;

    CountPlusMinus countPlusMinus;

    // Start is called before the first frame update
    void Start()
    {
        // Loading
        countSize = PlayerPrefs.GetInt("countSize", 0);
        for (int i = 0; i < countSize; i++)
        {
            textList.Add(PlayerPrefs.GetString("name" + i, "lol"));
            valueList.Add("" + i);
            countList.Add(PlayerPrefs.GetInt("num" + i, 5));
            memoList.Add(PlayerPrefs.GetString("memo" + i, ""));
            //CountPlusMinus.endCount = PlayerPrefs.GetInt("num" + i, 1);
            //countPlusMinus.SetStart();
            //Debug.Log(textList[i]);


            GameObject itemObj = (GameObject)Instantiate(itemPrefab);

            //GameObject item = GameObject.Find("num" + i);
            //countPlusMinus = item.GetComponent<CountPlusMinus>();
            //countPlusMinus.CountSet();

            itemObj.name = "" + num;
            num++;

            itemObj.transform.Find("Item_Name").gameObject.GetComponent<Text>().text = "" + textList[i];
            itemObj.transform.Find("Item_Value").gameObject.GetComponent<Text>().text = "" + countList[i];
            itemObj.transform.Find("memo").gameObject.GetComponent<InputField>().text = "" + memoList[i];
            itemObj.transform.SetParent(Content.transform, false);

            Debug.Log("now " + countList[i]);
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
    //public int ValueReturn(int i)
    //{
    //    return countList[i];
    //}

    public void AddList()
    {
        //countBox = countClick.ToString();
        //PlayerPrefs.SetString("" + countBox, ItemGenerator.textIn);

        textList.Add(ItemGenerator.textIn);////////////////////////////////////////////////////////////////////////////////////
        valueList.Add("" + num);
        countList.Add(1);
        memoList.Add(" ");

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
        memoList.RemoveAt(int.Parse(myName));
        Debug.Log("in "+ valueList.Count);
        //intList.Remove(CountPlusMinus.endCount);
    }

    public void DataDeleteButton()
    {
        //Debug.Log("ooooooooo");
        dataFlag = true;
        PlayerPrefs.DeleteAll();
    }

    public void ChangeCount(string myName)
    {
        int i = int.Parse(myName);
        countList[i] = CountPlusMinus.endCount;
        //Debug.Log("COUNTLIST" + countList[i]);
    }

    public void ChangeMemo(string myName, string memo)
    {
        int i = int.Parse(myName);
        memoList[i] = memo;
        Debug.Log("memoLIST" + i);
    }

    private void OnApplicationQuit()
    {
        if (dataFlag == false)
        {
            int check = 0;
            //GameObject[] box = GameObject.FindGameObjectsWithTag("item");
            // 終了時にセーブ
            for (int i = 0; i < valueList.Count; i++)
            {
                if (countList[i] > -1)
                {
                    Debug.Log("COUNTLIST" + countList[i]);
                    PlayerPrefs.SetString("name" + check, textList[i]);
                    PlayerPrefs.SetInt("num" + check, countList[i]);
                    PlayerPrefs.SetString("memo" + check, memoList[i]);
                    check++;

                    //Debug.Log("COUNTLIST" + countList[i]);
                }
            }
            PlayerPrefs.SetInt("countSize", check);
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
