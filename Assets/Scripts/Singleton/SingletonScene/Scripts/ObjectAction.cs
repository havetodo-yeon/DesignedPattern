using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    // �浹 �� ����� �ҽ� ������Ʈ�� ������ �÷��̸� �����ϰ� ��ü�� �ı��մϴ�.
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("���� ���");
        Destroy(gameObject);
    }

    // �� �ڵ尡 ����Ǹ� ���� ���� �߻��ϴ°�?
    // 1. ����� �÷��� �� ����� ��� �� �ı��˴ϴ�.
    // 2. ����� �÷��̰� ���� �ʰ� ����װ� ��µǰ� �ı��˴ϴ�.
    // 3. ������Ʈ�� �ٷ� �ı��˴ϴ�.
    // >> ���� : 2. play ������ ��ġ���� destroy�� �Ǳ� ������ ��ó ��µ��� �ʰ� �Ѿ

}
