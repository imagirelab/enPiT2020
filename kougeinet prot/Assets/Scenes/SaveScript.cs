using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScript : MonoBehaviour
{
    // color
    public static Color whiteC = new Color(0.9f, 0.9f, 0.9f, 1.0f);
    public static Color redC = new Color(1.0f, 0.4f, 0.4f, 1.0f);
    public static Color blueC = new Color(0.4f, 0.4f, 1.0f, 1.0f);
    public static Color greenC = new Color(0.4f, 1.0f, 0.4f, 0.8f);
    public static Color yellowC = new Color(1.0f, 1.0f, 0.4f, 0.8f);
    public static Color blackC = new Color(0.3f, 0.3f, 0.3f, 1.0f);
    public static Color purpleC = new Color(1.0f, 0.4f, 1.0f, 0.9f);
    public static Color cyanC = new Color(0.4f, 1.0f, 1.0f, 0.9f);
    public static Color orangeC = new Color(1.0f, 0.6f, 0.0f, 0.9f);
    public static Color dGreenC = new Color(0.0f, 0.6f, 0.0f, 0.9f);

    // List
    List<string> textList = new List<string>();
    List<string> valueList = new List<string>();
    List<int> countList = new List<int>();
    List<string> memoList = new List<string>();
    List<int> colorList = new List<int>();

    public GameObject itemPrefab;
    public GameObject Content;

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
            colorList.Add(PlayerPrefs.GetInt("color" + i, 0));

            GameObject itemObj = (GameObject)Instantiate(itemPrefab);

            itemObj.name = "" + num;
            num++;

            switch(colorList[i])
            {
                case 0:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = whiteC;
                    break;
                case 1:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = redC;
                    break;
                case 2:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = blueC;
                    break;
                case 3:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = greenC;
                    break;
                case 4:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = yellowC;
                    break;
                case 5:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = blackC;
                    break;
                case 6:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = purpleC;
                    break;
                case 7:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = cyanC;
                    break;
                case 8:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = orangeC;
                    break;
                case 9:
                    itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = dGreenC;
                    break;
                case 10:
                    //itemObj.transform.Find("ItemBox").gameObject.GetComponent<Image>().color = blackC;
                    break;
            }

            itemObj.transform.Find("Item_Name").gameObject.GetComponent<Text>().text = "" + textList[i];
            itemObj.transform.Find("Item_Value2").gameObject.GetComponent<InputField>().text = "" + countList[i];
            itemObj.transform.Find("memo").gameObject.GetComponent<InputField>().text = "" + memoList[i];
            itemObj.transform.SetParent(Content.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddList()
    {
        textList.Add(ItemGenerator.textIn);
        valueList.Add("" + num);
        countList.Add(1);
        memoList.Add("");
        colorList.Add(ColorChangeScript.colorNum);
    }

    public void DeleteList(string myName)
    {
        textList.RemoveAt(int.Parse(myName));
        valueList.Remove("" + myName);
        countList.RemoveAt(int.Parse(myName));
        memoList.RemoveAt(int.Parse(myName));
        colorList.RemoveAt(int.Parse(myName));
    }

    public void DataDeleteButton()
    {
        dataFlag = true;
        PlayerPrefs.DeleteAll();
    }

    public void ChangeCount(string myName)
    {
        int i = int.Parse(myName);
        countList[i] = CountPlusMinus.endCount;
    }

    public void ChangeCount2(string myName)
    {
        int i = int.Parse(myName);
        countList[i] = -1;
    }

    public void ChangeMemo(string myName, string memo)
    {
        int i = int.Parse(myName);
        memoList[i] = memo;
    }

    private void OnApplicationQuit()
    {
        if (dataFlag == false)
        {
            int check = 0;
            // 終了時にセーブ
            for (int i = 0; i < valueList.Count; i++)
            {
                if (countList[i] > -1)
                {
                    PlayerPrefs.SetInt("color" + check, colorList[i]);
                    PlayerPrefs.SetString("name" + check, textList[i]);
                    PlayerPrefs.SetInt("num" + check, countList[i]);
                    PlayerPrefs.SetString("memo" + check, memoList[i]);
                    check++;
                }
            }
            PlayerPrefs.SetInt("countSize", check);
        }
        else
        {
            dataFlag = false;
        }
    }


}
