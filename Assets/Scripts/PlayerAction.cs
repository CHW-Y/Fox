using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

    }

    //private void OnCollisionEnter(Collision coll)
    //{
    //    if (coll.gameObject.tag == "Food")
    //    {
    //        print("음식을 먹는다");
    //        anim.SetTrigger("Eat");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            print("음식을 먹는다");
            anim.SetTrigger("Eat");
        }
    }
}
