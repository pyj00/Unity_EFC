using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TalkingGUI : MonoBehaviour
{

    public TextMeshProUGUI talkText;
    // Start is called before the first frame update
    public void TalkText(string dial)
    {
        talkText.text = dial;
    }
}
