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
        // 파괴에 클립의 길이만큼 딜레이 (대기 시간을 추가)
    }

    // 이 코드가 실행되면 무슨 일이 발생하는가?
    // 1. 오디오 플레이 후 디버그 출력 후 파괴됩니다.
    // 2. 오디오 플레이가 되지 않고 디버그가 출력되고 파괴됩니다.
    // >> 정답 : 1. 
    // 사운드가 나지 않는 문제점은 해결되었으나, 부자연스러운 느낌이 존재함 (사운드 끝나고 파괴되기까지의 딜레이)
    // 따라서 동시 처리가 되면 좋을 듯 함 => 싱글톤 활용


}
