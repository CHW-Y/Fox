using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    GameObject unityChan;
    Animator anim;

    void Start()
    {

    }

    void Update()
    {
        if (unityChan == null)
        {
            unityChan = GameObject.FindWithTag("Girl");
            anim = unityChan.GetComponent<Animator>();
        }
    }

    public void OnWaterDrink()
    {
        anim.SetTrigger("Eat");
    }
}
