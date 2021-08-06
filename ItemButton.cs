using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    // Start is called before the first frame update

    Button button;
    Image itemIcon;
    int itemNo;
    
    void Awake()
    {
        button = GetComponent<Button>();
        itemIcon = transform.GetChild(0).GetComponent<Image>();
    }
    public void ItemButtonOn(int iconNo)
    {
        button.interactable = true;
        itemNo = iconNo;
        itemIcon.sprite = GameManager.Instance.itemSprite[iconNo];
    }

    public void ItemButtonInit()
    {
        button.interactable = false;
        itemNo = 0;
        itemIcon.sprite = GameManager.Instance.itemSprite[0];
    }
    //void Start()
    //{
    //    button = GetComponent<Button>();
    //    itemIcon = transform.GetChild(0).GetComponent<Image>();
    //}

    public void UseItem()
    {

    }
}
