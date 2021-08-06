using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchArea : MonoBehaviour
{
    Image touchArea;
    public int spaceNo;
    public int itemNo;
    public string dialog_Nor;
    public string dialog_GetItem;
    public string dialog_GetedItem;


    // Start is called before the first frame update
    void Start()
    {
        touchArea = GetComponent<Image>();
        //       touchArea.enabled = false;
    }

    public void TouchedButton()
    {
        if (GameManager.Instance.isGameStart)
        {
            GameManager.Instance.TouchCheck(spaceNo, itemNo, dialog_Nor, dialog_GetItem, dialog_GetedItem);
        }
    }


}