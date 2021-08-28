using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAction : MonoBehaviour
{
    [SerializeField]
    GameObject girl;
    [SerializeField]
    Animator anim;

    void Start()
    {
        girl = GameObject.FindGameObjectWithTag("Girl");
        anim = girl.GetComponent<Animator>();
    }

    void Update()
    {
        // 터치가 시작되었다면
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // 터치한 좌표를 레이로 바꾼다.
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                // 터치가 시작 시
                if (touch.phase == TouchPhase.Began)
                {
                    // 선택한 오브젝트의 태그가 Girl이면
                    if (hitInfo.collider.tag == "Girl")
                    {
                        // 선택 애니메이션 실행
                        anim.SetTrigger("Select");
                    }
                }
            }
        }
    }
}
