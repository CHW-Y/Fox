using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetSetActive : MonoBehaviour
{
    // 
    // dressSlot의 버튼?을 누르면 
    // costumes의 
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
