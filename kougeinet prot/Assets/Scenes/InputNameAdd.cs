using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Collections.Generic;

public class InputNameAdd : MonoBehaviour
{
    //オブジェクトと結びつける
    public InputField inputField;
    public static Text text;

    //List<string> myList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //Componentを扱えるようにする
        //inputField = inputField.GetComponent<InputField>();
        //text = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputText()
    {
        //テキストにinputFieldの内容を反映
        //text.text = inputField.text;
    }

    //void SetName()
    //{

    //}
}
