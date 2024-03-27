using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlayer : MonoBehaviour
{
    // 클립을 등록
    public AudioClip clip;

    // 충돌 시 매니저에서 해당 클립을 플레이
    // 오브젝트 파괴
    private void OnCollisionEnter(Collision collision)
    {
        AudioManager.Instance.Play(clip);

        Destroy(gameObject);
    }
}
