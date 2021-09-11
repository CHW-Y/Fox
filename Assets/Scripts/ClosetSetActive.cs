using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetSetActive : MonoBehaviour
{
    public GameObject closetModal;
    public GameObject closetExit;

    void Start()
    {
        closetModal.SetActive(false);
    }

    public void ClosetClick()
    {
        closetModal.SetActive(true);
    }

    public void ClosetExitClick()
    {
        closetModal.SetActive(false);
    }
}
