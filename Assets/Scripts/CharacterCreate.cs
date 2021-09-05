using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class CharacterCreate : MonoBehaviour
{
    public GameObject unityChan;

    // ȭ�� �߾ӿ��� AR ���� ���̸� �ߘ��� �浹�� ������ �ٴ��̶�� �� ���� ĳ���͸� �����Ѵ�
    ARRaycastManager rayManager;
    GameObject unityChanCharacter;

    bool isCreate = false;


    void Start()
    {
        rayManager = GetComponent<ARRaycastManager>();
        unityChanCharacter = Instantiate(unityChan);
        unityChanCharacter.SetActive(false);
    }

    void Update()
    {
        UnityChanCreate();
    }

    void UnityChanCreate()
    {
        // ��ũ���� �߾� ������ �ȼ� ��ǥ�� ���Ѵ�
        Vector2 centerPos = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

        List<ARRaycastHit> hitInfos = new List<ARRaycastHit>();

        // ��ũ�� �߾� �ȼ����� AR���̸� �߻��ؼ� �ٴ����¿� �ε����ٸ�...
        if (rayManager.Raycast(centerPos, hitInfos, TrackableType.Planes) && isCreate == false)
        {
            unityChanCharacter.SetActive(true);
            unityChanCharacter.transform.position = hitInfos[0].pose.position;
            //unityChanCharacter.transform.rotation = hitInfos[0].pose.rotation;
            unityChanCharacter.transform.Rotate(unityChanCharacter.transform.up, 180.0f);
            isCreate = true;
        }
        //else
        //{
        //    unityChanCharacter.SetActive(false);
        //}
    }
}
