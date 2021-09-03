using UnityEngine;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

public class GlobalDataImporter : MonoBehaviour
{
    [SerializeField]
    GoogleSheetData googleSheetData;

    [System.Serializable]
    public class GoogleSheetData
    {
        [Header("아이템")]
        public TextAsset item;

        [Header("스타일")]
        public TextAsset style;

        [Header("캐릭터")]
        public TextAsset character;

        [Header("제스쳐")]
        public TextAsset gesture;
    }

    void Awake()
    {
        //아이템 정보 담기
        GlobalState.itemList = JsonConvert.DeserializeObject<List<ExceldData_Item>>(googleSheetData.item.ToString());

        //스타일 정보 담기
        GlobalState.styleList = JsonConvert.DeserializeObject<List<ExceldData_Style>>(googleSheetData.style.ToString());

        //캐릭터 정보 담기
        GlobalState.characterList = JsonConvert.DeserializeObject<List<ExceldData_Character>>(googleSheetData.character.ToString());
        
        //캐릭터 정보 담기
        GlobalState.gestureList = JsonConvert.DeserializeObject<List<ExceldData_Gesture>>(googleSheetData.gesture.ToString());
    }
}
