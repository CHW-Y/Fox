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
        // ��ġ�� ���۵Ǿ��ٸ�
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // ��ġ�� ��ǥ�� ���̷� �ٲ۴�.
            Ray ray = Camera.main.ScreenPointToRay(touch.position);

            //if (raycastManager.Raycast(ray, hits))
            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                // ��ġ�� ���� ��
                if (touch.phase == TouchPhase.Began)
                {
                    // ������ ������Ʈ�� �±װ� Girl�̸�
                    if (hitInfo.collider.tag == "Girl")
                    {
                        if (!isSelected)
                        {
                            // ���� �ִϸ��̼� ����
                            anim.SetTrigger("Select");
                            isSelected = true;
                        }
                    }
                    else
                    {
                        // ���� ���
                        isSelected = false;
                    }
                }
                // ��ġ �� ������ ��
                if (touch.phase == TouchPhase.Moved)
                {
                    if (hitInfo.collider.tag == "head")
                    {
                        if (isSelected)
                        {
                            // ���ٵ�� ��ȣ�ۿ� �ִϸ��̼� ����
                            anim.SetTrigger("");
                        }
                    }
                }
            }
        }
    }
}
