using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameAdd : MonoBehaviour
{
    public Text nameText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName(string text)
    {
        nameText.text = "" + text;
    }

    public void SetNameTest()
    {
        nameText.text = "" + ItemGenerator.textIn;
    }
}
