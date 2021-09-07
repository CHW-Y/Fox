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

    public GameObject test1;
    public GameObject test2;
    public GameObject test3;
    public GameObject test4;
    //ARRaycastManager raycastManager;
    //List<ARRaycastHit> hits = new List<ARRaycastHit>();
    bool isSelected = false;

    //private void Start()
    //{
    //    if (girl == null) girl = GameObject.FindGameObjectWithTag("Girl");
    //    if (anim == null) anim = girl.GetComponent<Animator>();
    //    //raycastManager = GetComponent<ARRaycastManager>();
    //}
    void Update()
    {
        // 터치가 시작되었다면
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (test1 != null) test1.SetActive(true);
            // 터치한 좌표를 레이로 바꾼다.
            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            //if (raycastManager.Raycast(ray, hits))
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                // 터치가 시작 시
                if (touch.phase == TouchPhase.Began)
                {
                    if (test2 != null) test2.SetActive(true);
                    // 선택한 오브젝트의 태그가 Girl이면
                    if (hitInfo.collider.tag == "Girl")
                    {
                        if (test3 != null) test3.SetActive(true);

                        hitInfo.transform.gameObject.TryGetComponent(out anim);
                        
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
                        if (test4 != null) test4.SetActive(true);
                        // 쓰다듬기 상호작용 애니메이션 실행
                        anim.SetTrigger("Stroke");
                    }
                }
            }
        }
    }
}
