using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaDataManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(ExceldData_Character data in GlobalState.characterList)
        {
            Debug.Log(data.ID);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
