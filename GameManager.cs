using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    static GameManager instance = null;
    public int currentSpaceNo;
    public bool isGameStart;
    public Image getItemIamge;
    public GameObject[] space; // 공간을 배열로 저장함 특이하게0을 페이드인/아웃으로 설정하려 함
    public Sprite[] itemSprite;// 아이템 이미지 모음

    public int[] space1GetItem;// 얻어야할 아이템
    public List<int> space1GetedItemList;// 얻어낸 아이템 리스트


    //<UGUI> - Text 창
    public TalkingGUI talkGUI; // 메시지가 나가는 곳
    public bool isTexting;
    //<UGUI> - 아이템 창
    string dialog_Nor;// 아이템 획득 전
    string dialog_GetItem;// 아이템 획득 시
    string dialog_GetedItem;//아이템 획득 후

    public ItemButton[] itemButton;//고정되는 방식으로 n개가 들어감

    public static GameManager Instance//실제 접근
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    void Start()
    {
        if (null == instance)
        {
            instance = this;
        }
        currentSpaceNo = Mathf.Max(1, PlayerPrefs.GetInt("CurretSpaceNo"));//최소 스테이지 번호는 1이다.
        for (int i = 0; i < itemButton.Length; i++)
        {
            itemButton[i].ItemButtonInit();
        }
    }

    public void TouchCheck(int spaceNo, int itemNo, string normal, string getItem, string getedItem)
    {
        if (isTexting) return;
        if (itemNo == 0)
        {
            dialog_Nor = normal;
            getItemIamge.gameObject.SetActive(false);
            TalkTexting(normal);
        }
        else
        {
            if (spaceNo == currentSpaceNo)
            {
                switch (spaceNo)
                {
                    case 1:
                        if (space1GetedItemList.Count != 0)
                        {
                            for (int i = 0; i < space1GetItem.Length; i++)
                            {
                                for (int j = 0; j < space1GetedItemList.Count; j++)
                                {
                                    if (space1GetedItemList[j] != itemNo)
                                    {
                                        space1GetedItemList.Add(itemNo);
                                        getItemIamge.sprite = itemSprite[itemNo];
                                        getItemIamge.gameObject.SetActive(true);
                                        TalkTexting(getItem);
                                        break;
                                    }
                                    else
                                    {
                                        TalkTexting(getedItem);
                                        getItemIamge.gameObject.SetActive(false);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            getItemIamge.sprite = itemSprite[itemNo];
                            getItemIamge.gameObject.SetActive(true);
                            space1GetedItemList.Add(itemNo);
                            int crNo = space1GetedItemList.Count - 1;
                            Debug.Log("crNo" + crNo);
                            GameManager.Instance.itemButton[crNo].ItemButtonOn(space1GetedItemList[crNo]);
                            TalkTexting(getItem);
                            break;
                        }
                        break;
                }
            }
        }
    }



    public void TalkTexting(string dial)
    {
        talkGUI.TalkText(dial);
        talkGUI.gameObject.SetActive(true);
        isTexting = true;
        Invoke("TalkGUIOff", 5f);
    }

    void TalkGUIOff()
    {
        isTexting = false;
        getItemIamge.gameObject.SetActive(false);
        talkGUI.gameObject.SetActive(false);
    }


    void ItemButtonOn()
    {

    }

    public int[] space2GetItem;// 얻어야할 아이템
    public int[] space3GetItem;// 얻어야할 아이템
    public int[] space4GetItem;// 얻어야할 아이템
    public int[] space5GetItem;// 얻어야할 아이템

}


