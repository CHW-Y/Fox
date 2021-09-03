using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TouchAction : MonoBehaviour
{
    [SerializeField]
    GameObject girl;
    [SerializeField]
    Animator anim;
    //ARRaycastManager raycastManager;
    //List<ARRaycastHit> hits = new List<ARRaycastHit>();
    bool isSelected = false;

    void Start()
    {
        girl = GameObject.FindGameObjectWithTag("Girl");
        anim = girl.GetComponent<Animator>();
        //raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        // 터치가 시작되었다면
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // 터치한 좌표를 레이로 바꾼다.
            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            //if (raycastManager.Raycast(ray, hits))
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                // 터치가 시작 시
                if (touch.phase == TouchPhase.Began)
                {
                    // 선택한 오브젝트의 태그가 Girl이면
                    if (hitInfo.collider.tag == "Girl")
                    {
                        // 선택 애니메이션 실행
                        anim.SetTrigger("Select");
                        isSelected = true;
                    }
                }
                // 터치 후 움직일 시
                if (touch.phase == TouchPhase.Moved)
                {
                    if (hitInfo.collider.tag == "head")
                    {
                        // 쓰다듬기 상호작용 애니메이션 실행
                        anim.SetTrigger("Stroke");
                    }
                }
            }
        }
    }
}
