using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TouchAction : MonoBehaviour
{
    Animator anim;

    bool isSelected = false;



    void Update()
    {
        // 터치가 시작되었다면
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // 터치한 좌표를 레이로 바꾼다.
            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                // 터치가 시작 시
                if (touch.phase == TouchPhase.Began)
                {
                    // 선택한 오브젝트의 태그가 Girl이고, 캐릭터 선택 중이 아니라면
                    if (hitInfo.collider.tag == "Girl" && !isSelected)
                    {
                        //hitInfo.transform.gameObject.TryGetComponent(out anim);
                        // 애니메이터를 받아온다.
                        anim = hitInfo.transform.GetComponent<Animator>();

                        // 선택 애니메이션 실행
                        anim.SetTrigger("Select");

                        // 캐릭터 선택 중
                        isSelected = true;
                    }
                    // 캐릭터를 선택 중인데 다른 곳을 터치하면
                    else
                    {
                        // 캐릭터 선택 해제
                        isSelected = false;
                    }
                }
                // 터치 후 움직일 시
                if (touch.phase == TouchPhase.Moved)
                {
                    if (hitInfo.collider.tag == "head" && isSelected)
                    {
                        //anim = hitInfo.transform.GetComponentInParent<Animator>();

                        // 쓰다듬기 상호작용 애니메이션 실행
                        anim.SetBool("Stroke", true);
                    }
                    else
                    {
                        // 쓰다듬기 상호작용 애니메이션 종료
                        anim.SetBool("Stroke", false);
                    }
                }
                // 터치가 끝나면
                if (touch.phase == TouchPhase.Ended)
                {
                    // 쓰다듬기 상호작용 애니메이션 종료
                    anim.SetBool("Stroke", false);
                }
            }
        }
    }
}
