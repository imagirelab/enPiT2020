using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletebutton : MonoBehaviour
{
    SaveScript saveScript;

    public GameObject popUp;
    private bool popFlag;

    string myName;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scriptOnly = GameObject.Find("ScriptOnly");
        saveScript = scriptOnly.GetComponent<SaveScript>();
        myName = gameObject.name;
        popFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dele()
    {
        myName = gameObject.name;
        saveScript.ChangeCount2(myName);
        Destroy(this.gameObject);
    }

    public void PopClick()
    {
        if (popFlag == false)
        {
            popUp.SetActive(true);
            popFlag = true;
        }
        else
        {
            popUp.SetActive(false);
            popFlag = false;
        }
    }
}
