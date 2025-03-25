using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 mousePos =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.nearClipPlane)); 
        Vector3 dir = mousePos - Camera.main.transform.position; //���콺�� Ŭ���� ��ġ�� ���� ��
        dir = dir.normalized; // 1�� ����ȭ

        RaycastHit hit; // �ε��� ������
        if(Physics.Raycast(Camera.main.transform.position, dir, out hit)) // ī�޶�� ������Ʈ ��ġ
        {
            Debug.Log($"Raycast Camera {hit.collider.gameObject.name}");
        }
    }
}
