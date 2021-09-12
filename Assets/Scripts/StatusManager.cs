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
        GlobalState.currentHpCnt = cnt;
        hpCntText.text = cnt.ToString();
    }

    public void SetSpCnt(float cnt)
    {
        GlobalState.currentSpCnt = cnt;
        spCntSlider.value = cnt;
        spCntSlider.maxValue = 10;
    }

}
