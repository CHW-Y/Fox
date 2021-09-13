using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject FoodUI;

    public void OnFoodSetActiveTrue()
    {
        FoodUI.SetActive(true);
    }

    public void OnFoodSetActiveFalse()
    {
        FoodUI.SetActive(false);
    }
}
