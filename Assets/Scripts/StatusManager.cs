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
    Slider spCntSlider;

    public void SetHpCnt(float cnt)
    {
        GlobalState.currentHpCnt += cnt;
        hpCntText.text = GlobalState.currentSpCnt.ToString();
    }

    public void SetSpCnt(float cnt)
    {
        GlobalState.currentSpCnt += cnt;
        spCntSlider.value = GlobalState.currentSpCnt;
    }

}
