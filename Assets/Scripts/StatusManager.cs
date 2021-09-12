using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public static StatusManager intance;
    private void Awake()
    {
        if(intance == null)intance = this;
    }

    [SerializeField]
    Text hpCntText;

    [SerializeField]
    Text spCntText;

    public void SetHpCnt(float cnt)
    {
        GlobalState.currentHpCnt = cnt;
        hpCntText.text = cnt.ToString();
    }

    public void SetSpCnt(float cnt)
    {
        GlobalState.currentSpCnt = cnt;
        spCntText.text = cnt.ToString();
    }

}
