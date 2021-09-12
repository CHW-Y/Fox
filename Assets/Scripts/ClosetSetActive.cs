using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetSetActive : MonoBehaviour
{
    public void ClosetClick()
    {
        gameObject.SetActive(true);
    }

    public void ClosetExitClick()
    {
        gameObject.SetActive(false);
    }
}
