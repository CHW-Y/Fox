using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeChange : MonoBehaviour
{
    public int selectedIndex;

    public void SetIndex(int id)
    {
        selectedIndex = id;
        StatusManager.intance.SetSaveStyle(id);
        GameObject unityChan = GameObject.FindWithTag("Girl");
        if(unityChan != null)
        {
            unityChan.TryGetComponent(out CostumeManager cos);
            cos.SetCostume();
        }
    }
}
