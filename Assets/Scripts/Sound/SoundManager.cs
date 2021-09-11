using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    void Awake()
    {
        if (instance == null) instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public float bgVolum = 0.3f;
    public float effectVolum = 0;

    [SerializeField]
    AudioSource bgAudioSource;

    public delegate void BGSoundDel();
    public delegate void EffectSoundDel();
    public BGSoundDel bgSoundFunc;
    public EffectSoundDel effectSoundFunc;

    void Start()
    {
        effectSoundFunc = ()=> { };
        if (bgAudioSource != null) SetBgSound(bgAudioSource);
    }
    /// <summary>
    /// Set BackGround Sound Audio 
    /// </summary>
    /// <param name="audio">AudioSource</param>
    public void SetBgSound(AudioSource audio)
    {
        bgSoundFunc += ()=> {
            if (audio != null) audio.volume = bgVolum;
        };
    }

    /// <summary>
    /// On BackGround Sound Volum
    /// </summary>
    /// <param name="volum"></param>
    public void OnBgSoundVolume(float volum = -1f)
    {
        if(volum != -1f) bgVolum = volum;
        bgSoundFunc();
    }

    /// <summary>
    /// Set Effect Sound Audio 
    /// </summary>
    /// <param name="audio">AudioSource</param>
    public void SetEffectSound(AudioSource audio)
    {
        effectSoundFunc += () => {
            if(audio != null) audio.volume = effectVolum;
        };
    }

    /// <summary>
    /// On Effect Sound Volum
    /// </summary>
    /// <param name="volum"></param>
    public void OnEffectSoundVolume(float volum = -1f)
    {
        if (volum != -1f) effectVolum = volum;
        effectSoundFunc();
    }

}
