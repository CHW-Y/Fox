using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject FoodUI;

    GameObject unityChan;
    Animator anim;
    StatusManager statusManager;

    void Start()
    {

    }

    void Update()
    {
        //if (unityChan == null)
        //{
        //    unityChan = GameObject.FindWithTag("Girl");
        //    anim = unityChan.GetComponent<Animator>();
        //}
    }

    public void OnWaterDrink()
    {
        FoodUI.SetActive(false);
        //anim.SetTrigger("Eat");
        statusManager.SetSpCnt(1f);
    }
}
