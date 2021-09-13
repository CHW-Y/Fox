using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLoadingManager : MonoBehaviour
{
    [SerializeField]
    Slider loadingBar;

    [Serializable]
    class PlayUI
    {
        public GameObject playBtn;
        public GameObject playImg;
        public AudioSource playSound;
    }
    [SerializeField]
    PlayUI playUI;

    [SerializeField]
    Animator unityChanAnim;
    
    [Serializable]
    class BG
    {
        [Header("배경")]
        public MeshRenderer bgMesh;

        [Header("메터리얼")]
        public Material[] materials;
    }
    [SerializeField]
    BG bg;

    void Start()
    {
        playUI.playBtn.SetActive(false);
        StartCoroutine(LoadingCoroutine());
        SetChangeBackGound();

        StartCoroutine(CoroutineGesture());
    }

    /// <summary>
    /// Gesture Coroutine
    /// </summary>
    /// <returns></returns>
    IEnumerator CoroutineGesture()
    {
        WaitForSeconds wait5s = new WaitForSeconds(5);
        while (true)
        {
            SetRandomGesture();
            yield return wait5s;
        }
    }
    /// <summary>
    /// Random Gesture
    /// </summary>
    public void SetRandomGesture()
    {
        string[] trigger = new string[]{ "IdleA","Run","Loop","EmotionClap" };
        unityChanAnim.SetTrigger(trigger[UnityEngine.Random.Range(0, trigger.Length)]);
    }

    /// <summary>
    /// Random BackGround
    /// </summary>
    public void SetChangeBackGound()
    {
        bg.bgMesh.material = bg.materials[UnityEngine.Random.Range(0, bg.materials.Length)];
    }

    /// <summary>
    /// Load Scene
    /// </summary>
    public void OnStartBtn()
    {
        playUI.playBtn.SetActive(false);
        StartCoroutine(PlayBtnFlicker());
    }
    IEnumerator PlayBtnFlicker()
    {
        playUI.playSound.Play();
        WaitForSeconds wait = new WaitForSeconds(0.2f);
        bool ative = true;
        while (playUI.playSound.isPlaying)
        {
            playUI.playImg.SetActive(ative);
            yield return wait;
            ative = !ative;
        }
        yield return wait;
        playUI.playImg.SetActive(false);
        SceneManager.LoadSceneAsync(1);
    }


    /// <summary>
    /// Loading Process
    /// </summary>
    IEnumerator LoadingCoroutine()
    {
        WaitForSeconds wait01s = new WaitForSeconds(0.2f);
        int[] dataCntArray = { GlobalState.itemList.Count, GlobalState.styleList.Count, GlobalState.characterList.Count, GlobalState.gestureList.Count };
        Array.Sort(dataCntArray);

        int sliderCnt = 0;
        int maxCnt = dataCntArray[dataCntArray.Length - 1];

        if(loadingBar != null)
        {
            loadingBar.value = 0;
            loadingBar.maxValue = maxCnt;
        }

        GlobalState.itemDict = new Dictionary<string, ExceldData_Item>();
        GlobalState.styleDict = new Dictionary<string, ExceldData_Style>();
        GlobalState.charaterDict = new Dictionary<string, ExceldData_Character>();
        GlobalState.gestureDict = new Dictionary<string, ExceldData_Gesture>();

        string name = "";
        for (int i = 0; i < maxCnt; i++)
        {
            if(i < GlobalState.itemList.Count)
            {
                name = GlobalState.itemList[i].Name;
                if (name != "")
                {
                    GlobalState.itemDict.Add(name, GlobalState.itemList[i]);
                    yield return new WaitUntil(() => GlobalState.itemDict.ContainsKey(name));
                }
            }

            if(i < GlobalState.styleList.Count)
            {
                name = GlobalState.styleList[i].Name;
                if(name != "")
                {
                    GlobalState.styleDict.Add(name, GlobalState.styleList[i]);
                    yield return new WaitUntil(() => GlobalState.styleDict.ContainsKey(name));
                }
            }

            if(i < GlobalState.characterList.Count)
            {
                name = GlobalState.characterList[i].Name;
                if (name != "")
                {
                    GlobalState.charaterDict.Add(name, GlobalState.characterList[i]);
                    yield return new WaitUntil(() => GlobalState.charaterDict.ContainsKey(name));
                }
            }

            if(i < GlobalState.gestureList.Count)
            {
                name = GlobalState.gestureList[i].Name;
                if (name != "")
                {
                    GlobalState.gestureDict.Add(name, GlobalState.gestureList[i]);
                    yield return new WaitUntil(() => GlobalState.gestureDict.ContainsKey(name));
                }
            }

            //로딩바 보여주는 용도(없어도 됨)
            yield return wait01s;

            ++sliderCnt;
            if (loadingBar != null) loadingBar.value = sliderCnt;
        }
      
        yield return new WaitUntil(() => true);
        playUI.playBtn.SetActive(true);
    }
    
}
