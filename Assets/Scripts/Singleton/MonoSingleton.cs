using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton : MonoBehaviour
{
    private static MonoSingleton instance;
    public static MonoSingleton Instance
    {
        get
        {
            if(instance == null)
            {
                // 1. ���� ���� MonoSingleton ������ ������Ʈ�� �����ϴ��� Ȯ���մϴ�.
                var obj = FindObjectOfType<MonoSingleton>();
                // ������Ʈ�� �����Ѵٸ� �ν��Ͻ��� �ش� ������ ó���մϴ�.
                if(obj != null)
                {
                    instance = obj;
                }
                else    // �Ϲ������� �� �κ��� ����� ���� ����
                {
                    // ���� ������Ʈ�� "MonoSingleton"�� �̸����� �����ϰ� MonoSingleton ������Ʈ�� �߰��մϴ�.
                    var newObject = new GameObject("MonoSingleton").AddComponent<MonoSingleton>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        // MonoSingleton ������ ������Ʈ���� ���ӿ��� �����մϴ�.
        var obj = FindObjectsOfType<MonoSingleton>();
        
        // ������Ʈ �迭�� ���̰� 1�� �ƴ϶�� (���� ��ü�� �ƴ� ���)
        if(obj.Length != 1)
        {
            Destroy(gameObject);
            return;
        }
        // �ش� �ڵ带 �۾��� ��� ���� �̵��ص� �����˴ϴ�.
        DontDestroyOnLoad(gameObject);
    }

}
