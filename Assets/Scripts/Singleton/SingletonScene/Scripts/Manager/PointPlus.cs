using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPlus : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // �̱��� Ŭ����.Instance.�޼ҵ���� ���� ��� ���
            int result = AudioManager.Instance.getPoint();
            Debug.Log($"���� ����Ʈ : {result}");
        }
    }
}
