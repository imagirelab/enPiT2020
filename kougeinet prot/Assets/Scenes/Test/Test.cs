using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentTransform;

    bool flag = false;
    Collider2D nowCol;

    public void OnBeginDrag(PointerEventData data)
    {


        //Debug.Log("OnBeginDrag");
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        parentTransform = transform.parent;
        transform.SetParent(transform.parent.parent);

    }
    public void OnDrag(PointerEventData data)
    {
        //transform.position = new Vector3(0f, data.position.y, 0f);
        transform.position = data.position;
    }
    public void OnEndDrag(PointerEventData data)
    {
        //Debug.Log("OnEndDrag");
        if (flag == true)
        {
            //transform.parent = GameObject.Find("ParentBox").transform;
            GetComponent<BoxCollider2D>().enabled = false;
            transform.parent = nowCol.gameObject.transform.Find("ParentBox").transform;
            //transform.SetParent(parentTransform);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        else
        {
            transform.parent = GameObject.Find("Content").transform;
            //transform.SetParent(parentTransform);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)//当たり判定
    //{
    //    //transform.parent =  GameObject.Find("").transform;
    //    Debug.Log(2);
    //}
    private void OnTriggerStay2D(Collider2D collision)
    {
        flag = true;
        nowCol = collision;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        flag = false;
    }
}