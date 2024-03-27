using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActionDelayed : MonoBehaviour
{
    private AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_AudioSource.Play();
        Destroy(gameObject, m_AudioSource.clip.length);
        // �ı��� Ŭ���� ���̸�ŭ ������ (��� �ð��� �߰�)
    }

    // �� �ڵ尡 ����Ǹ� ���� ���� �߻��ϴ°�?
    // 1. ����� �÷��� �� ����� ��� �� �ı��˴ϴ�.
    // 2. ����� �÷��̰� ���� �ʰ� ����װ� ��µǰ� �ı��˴ϴ�.
    // >> ���� : 1. 
    // ���尡 ���� �ʴ� �������� �ذ�Ǿ�����, ���ڿ������� ������ ������ (���� ������ �ı��Ǳ������ ������)
    // ���� ���� ó���� �Ǹ� ���� �� �� => �̱��� Ȱ��


}
