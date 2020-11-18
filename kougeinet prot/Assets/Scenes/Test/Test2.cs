using UnityEngine;
using UnityEngine.EventSystems;

public class Test2 : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData data)
    {
        //Debug.Log(gameObject.name);

        Test dragObj = data.pointerDrag.GetComponent<Test>();
        if (dragObj != null)
        {
            dragObj.parentTransform = this.transform;
            Debug.Log(gameObject.name + "に" + data.pointerDrag.name + "をドロップ");
        }
    }
}