using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlayer : MonoBehaviour
{
    // Ŭ���� ���
    public AudioClip clip;

    // �浹 �� �Ŵ������� �ش� Ŭ���� �÷���
    // ������Ʈ �ı�
    private void OnCollisionEnter(Collision collision)
    {
        AudioManager.Instance.Play(clip);

        Destroy(gameObject);
    }
}
