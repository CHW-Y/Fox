using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetSetActive : MonoBehaviour
{
    public GameObject closetModal;
    public GameObject closetExit;
    public GameObject backGround;

    void Start()
    {
        closetModal.SetActive(false);
        backGround.SetActive(false);
    }

    public void ClosetClick()
    {
        closetModal.SetActive(true);
        backGround.SetActive(true);
    }

    public void ClosetExitClick()
    {
        closetModal.SetActive(false);
        backGround.SetActive(false);
    }
}
