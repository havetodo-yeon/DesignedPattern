using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreater : MonoBehaviour
{
    public GameObject SpherePrefab;

    void Update()
    {
        // 마우스 왼쪽 버튼을 누르면 정해진 좌표에 프리팹 생성을 진행하겠습니다.
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = new Vector3(0, 3.1f, 0);
            Instantiate(SpherePrefab, pos, Quaternion.identity);
        }
    }
}
