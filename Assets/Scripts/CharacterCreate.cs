using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class CharacterCreate : MonoBehaviour
{
    public GameObject unityChan;

    // 화면 중앙에서 AR 전용 레이를 발샇서 충돌한 지점이 바닥이라면 그 위에 캐릭터를 생성한다
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
        // 스크린의 중앙 지점의 픽셀 좌표를 구한다
        Vector2 centerPos = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

        List<ARRaycastHit> hitInfos = new List<ARRaycastHit>();

        // 스크린 중앙 픽셀에다 AR레이를 발사해서 바닥형태에 부딪혔다면...
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
