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
        Vector3 dir = mousePos - Camera.main.transform.position; //마우스의 클릭한 위치로 가는 길
        dir = dir.normalized; // 1로 정상화

        RaycastHit hit; // 부딪힌 데이터
        if(Physics.Raycast(Camera.main.transform.position, dir, out hit)) // 카메라와 오브젝트 위치
        {
            Debug.Log($"Raycast Camera {hit.collider.gameObject.name}");
        }
    }
}
