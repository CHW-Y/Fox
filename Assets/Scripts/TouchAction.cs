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
        // ��ġ�� ���۵Ǿ��ٸ�
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // ��ġ�� ��ǥ�� ���̷� �ٲ۴�.
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                // ��ġ�� ���� ��
                if (touch.phase == TouchPhase.Began)
                {
                    // ������ ������Ʈ�� �±װ� Girl�̸�
                    if (hitInfo.collider.tag == "Girl")
                    {
                        // ���� �ִϸ��̼� ����
                        anim.SetTrigger("Select");
                    }
                }
            }
        }
    }
}
