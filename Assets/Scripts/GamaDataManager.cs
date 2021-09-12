using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaDataManager : MonoBehaviour
{
    void Start()
    {
        foreach(ExceldData_Character data in GlobalState.characterList)
        {
            //Debug.Log(data.ID);
        }

        if(GlobalState.itemDict.ContainsKey("사과")){
            ExceldData_Item itemData = GlobalState.itemDict["사과"];
            //Debug.Log(itemData.ID);
        }
    }

    void SetHpCnt()
    {

    }
   
}
