using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetSetActive : MonoBehaviour
{
    // 
    // dressSlot�� ��ư?�� ������ 
    // costumes�� 
    public GameObject[] costumes;
    public GameObject[] dressSlot;

    public void ClosetClick()
    {
        gameObject.SetActive(true);
    }

    public void ClosetExitClick()
    {
        gameObject.SetActive(false);
    }
}
