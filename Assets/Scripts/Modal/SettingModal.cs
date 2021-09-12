using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingModal : MonoBehaviour
{
    [SerializeField]
    Slider bgSlider;

    [SerializeField]
    Slider effectSlider;

    void Start()
    {
        bgSlider.value = SoundManager.instance.bgVolum;
        effectSlider.value = SoundManager.instance.effectVolum;
    }

    public void OnChangeBGSoundVolume()
    {
        SoundManager.instance.OnBgSoundVolume(bgSlider.value);
    }

    public void OnChangeEffectSoundVolume()
    {
        SoundManager.instance.OnEffectSoundVolume(effectSlider.value);
    }

    public void OnGameExit()
    {
        Application.Quit();
    }

    public void OpenModal()
    {
        gameObject.SetActive(true);
    }

    public void OnCloseModal()
    {
        gameObject.SetActive(false);
    }
}
