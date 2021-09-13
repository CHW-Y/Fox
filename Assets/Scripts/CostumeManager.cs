using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] costumes;

    public void SetCostume()
    {
        int id = StatusManager.intance.GetStyleData();

        for (int i = 0; i < costumes.Length; i++) {
            costumes[i].SetActive(i == id);
        }
    }
}
