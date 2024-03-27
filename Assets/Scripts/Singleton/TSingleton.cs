using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ���׸� Ŭ����
// class Ŭ������<T>�� �����ϸ� T �ڸ��� Ÿ���� ���� �� �ֽ��ϴ�.

// ���׸� ���� ����
// where T : struct             => T�� null�� ������� �ʴ� ���� ����
// where T : class              => T�� ����(Reference) ����
// where T : new()              => �⺻ �����ڰ� �־�� �մϴ�. �ٸ� ���� ���ǰ� ���� ���� ��� ���� ������ �ۼ��˴ϴ�.
// where T : notnull            => T�� null�� �ƴ� ����, ���� ���� ���� �� ������ �ƴ� ��� �߰� �˴ϴ�.
// where T : (base)className    => T�� ������ �⺻ Ŭ�����̰ų� �� Ŭ�������� �Ļ��� Ŭ�������� �մϴ�.
// where T : interfaceName      => T�� ������ �⺻ �������̽��̰ų� �� �������̽����� �Ļ��� �����̾�� �մϴ�.

// Ÿ�� �Ķ���Ͱ� 2�� �̻��� ��쿡�� ���� ������ ���� �ۼ��ϴ� ���� �����մϴ�.
// public class MultiType<T, K> where T: struct where K : class { }


public class TSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public int value;

    private static T _instance;
    // T �ڸ����� �ش� Ŭ������ ��ӹ޴� Ŭ������ Ÿ���� ���� �� �ֽ��ϴ�.
    // �̶� �� Ŭ������ MonoBehaviour �Ǵ� MonoBehaviour�� ��ӹ��� Ŭ�����Դϴ�.

    private static bool _ShutDown = false;
    private static object _Lock = new object();

    // ������Ƽ�� �ַ� ������ �ҹ��ڷ� ������ �� �ձ��ڸ� �빮�ڷ� ���� ��찡 �����ϴ�.
    public static T Instance
    {
        get
        {
            // ���� ���� �� ������Ʈ���� �̱����� OnDestroy�� ���� ����� �� �ִ� ��Ȳ�� ���� ����
            if (_ShutDown)
            {
                return null;
            }

            // C#�� lock ���
            // Ư�� ���� �ڵ带 �� ���� �ϳ��� �����常 ������ �� �ֵ��� ó�����ִ� ����
            // ���α׷����� ���� �ڿ����� ���Ǵ� ���鿡 �ַ� ���Ǵ� Ű�����Դϴ�.
            lock(_Lock)
            {
                if(_instance == null)
                {
                    // �ν��Ͻ��� ���� �����ϴ����� üũ�մϴ�.
                    _instance = FindObjectOfType<T>();

                    // ���縦 �ߴµ��� �������� �ʾ��� ���
                    if(_instance == null)
                    {
                        // �� ������Ʈ ����
                        var sObj = new GameObject();
                        // �ν��Ͻ� ��ä T�� ������Ʈ�� �߰��� sObj�� �Ҵ�
                        _instance = sObj.AddComponent<T>();
                        sObj.name = typeof(T).Name + "(Singleton)";

                        DontDestroyOnLoad(sObj);
                    }
                }
                return _instance;
            }

        }
    }

    private void OnApplicationQuit()
    {
        _ShutDown = true;
    }

    private void OnDestroy()
    {
        _ShutDown = false;
    }

}
