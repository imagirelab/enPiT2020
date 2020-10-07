using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScript : MonoBehaviour
{
    List<int> intList = new List<int>();
    List<string> textList = new List<string>();
    int countClick = 0;
    string countBox;

    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < intlist.Count; i++)
        //{
        //    intlist[i] = PlayerPrefs.GetInt("", 1);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddList()
    {
        countBox = countClick.ToString();
        PlayerPrefs.SetString("" + countBox, ItemGenerator.textIn);
        //textList.Add(ItemGenerator.textIn);
        //Debug.Log(textList.Count);
        countClick++;
    }

    public void DeleteList()
    {
        PlayerPrefs.DeleteKey("" + countBox);
        //textList.Remove(ItemGenerator.textIn);
    }
}
