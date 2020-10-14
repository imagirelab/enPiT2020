using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameAdd : MonoBehaviour
{
    public Text nameText;

    //InputNameAdd inputNameAdd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void NameAddClick(string text)
    //{
    //    //nameText.text = InputNameAdd.inputField.text;
    //    nameText.text = "" + text;
    //}

    public void SetName(string text)
    {
        nameText.text = "" + text;
    }

    public void SetNameTest()
    {
        nameText.text = "" + ItemGenerator.textIn;
    }
}
