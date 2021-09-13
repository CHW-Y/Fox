using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject FoodUI;

    GameObject unityChan;
    Animator anim;

    public void OnWaterDrink()
    {
        if (unityChan == null)
        {
            unityChan = GameObject.FindWithTag("Girl");
            anim = unityChan.GetComponent<Animator>();
        }

        FoodUI.SetActive(false);
        anim.SetTrigger("Eat");
        StatusManager.intance.SetSpCnt(1f);
    }
}
