using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreater : MonoBehaviour
{
    public GameObject SpherePrefab;

    void Update()
    {
        // ���콺 ���� ��ư�� ������ ������ ��ǥ�� ������ ������ �����ϰڽ��ϴ�.
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = new Vector3(0, 3.1f, 0);
            Instantiate(SpherePrefab, pos, Quaternion.identity);
        }
    }
}
