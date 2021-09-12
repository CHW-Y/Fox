using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAction : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision coll)
    //{
    //    if (coll.gameObject.tag == "Girl")
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Girl")
        {
            Destroy(gameObject);
        }
    }
}
