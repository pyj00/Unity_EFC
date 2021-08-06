using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelectGUI : MonoBehaviour
{
    public ItemButton[] buttons;
    public Image[] itemIcon;
    public Button[] itemButton;
    // Start is called before the first frame update
  public  void ButtonInit()//버튼 등록
    {
        Debug.Log("transform.childCount" + transform.childCount);
        for (int i =0; i< transform.childCount; i++)
        {
            itemButton[i] =  transform.GetChild(i).GetComponentInChildren<Button>();
            itemButton[i].interactable = false;
            itemIcon[i] = itemButton[i].transform.GetChild(0).GetComponent<Image>();
            itemIcon[i].sprite = GameManager.Instance.itemSprite[0];
        }
    }


    public void ItemButtonOn(int btnNo, int iconNo)
    {
        itemButton[btnNo].interactable = true;
        itemIcon[btnNo].sprite = GameManager.Instance.itemSprite[iconNo];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
