using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalState : MonoBehaviour
{
    public static List<ExceldData_Item> itemList;
    public static List<ExceldData_Style> styleList;
    public static List<ExceldData_Character> characterList;
    public static List<ExceldData_Gesture> gestureList;

    public static Dictionary<string, ExceldData_Item> itemDict;
    public static Dictionary<string, ExceldData_Style> styleDict;
    public static Dictionary<string, ExceldData_Character> charaterDict;
    public static Dictionary<string, ExceldData_Gesture> gestureDict;
}
