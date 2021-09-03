using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class GameLoadingManager : MonoBehaviour
{
    [SerializeField]
    Slider loadingBar;

    [SerializeField]
    GameObject[] Btns;

    void Start()
    {
        Btns[0].SetActive(false);
        Btns[1].SetActive(true);
        StartCoroutine(LoadingCoroutine());
    }

    IEnumerator LoadingCoroutine()
    {
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

            ++sliderCnt;
            if (loadingBar != null) loadingBar.value = sliderCnt;
        }
      
        yield return new WaitUntil(() => true);
        Btns[1].SetActive(false);
        Btns[0].SetActive(true);
    }
    
}
