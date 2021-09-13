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

    void Start()
    {
        hpCntText.text = PlayerPrefs.HasKey("currentHpCnt") ? PlayerPrefs.GetFloat("currentHpCnt").ToString() : "0";
        spCntSlider.value = PlayerPrefs.HasKey("currentSpCnt") ? PlayerPrefs.GetFloat("currentSpCnt") : 0;
    }

    /// <summary>
    /// ??? ??? ??? ????
    /// </summary>
    /// <returns>??? ID</returns>
    public int GetStyleData()
    {
        int id = 0;
        if (PlayerPrefs.HasKey("currentStyle")) id = PlayerPrefs.GetInt("currentStyle");
        return id;
    }
    
    /// <summary>
    /// ??? HP ??? ???? 
    /// </summary>
    /// <returns>HP??</returns>
    public float GetHpCnt()
    {
        float cnt = 0;
        if (PlayerPrefs.HasKey("currentHpCnt")) cnt = PlayerPrefs.GetFloat("currentHpCnt");
        return cnt;
    }

    /// <summary>
    /// ??? SP ??? ???? 
    /// </summary>
    /// <returns>SP??</returns>
    public float GetSpCnt()
    {
        float cnt = 0;
        if (PlayerPrefs.HasKey("currentSpCnt")) cnt = PlayerPrefs.GetFloat("currentSpCnt");
        return cnt;
    }

    /// <summary>
    /// ??? ??? ??
    /// </summary>
    /// <param name="id">??? ID</param>
    public void SetSaveStyle(int id)
    {
        PlayerPrefs.SetInt("currentStyle", id);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// HP ??? ??
    /// </summary>
    /// <param name="cnt">HP??</param>
    public void SetHpCnt(float cnt)
    {
        GlobalState.currentHpCnt += cnt;
        hpCntText.text = GlobalState.currentHpCnt.ToString();

        //??
        PlayerPrefs.SetFloat("currentHpCnt", GlobalState.currentHpCnt);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// SP ??? ??
    /// </summary>
    /// <param name="cnt">SP??</param>
    public void SetSpCnt(float cnt)
    {
        GlobalState.currentSpCnt += cnt;
        if (GlobalState.currentSpCnt > 10) GlobalState.currentSpCnt = 10;
        spCntSlider.value = GlobalState.currentSpCnt;

        //??
        PlayerPrefs.SetFloat("currentSpCnt", GlobalState.currentSpCnt);
        PlayerPrefs.Save();
    }

}
