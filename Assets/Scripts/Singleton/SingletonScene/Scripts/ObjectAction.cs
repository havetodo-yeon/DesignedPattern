using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    // 충돌 시 오디오 소스 컴포넌트를 가져와 플레이를 진행하고 물체를 파괴합니다.
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("사운드 출력");
        Destroy(gameObject);
    }

    // 이 코드가 실행되면 무슨 일이 발생하는가?
    // 1. 오디오 플레이 후 디버그 출력 후 파괴됩니다.
    // 2. 오디오 플레이가 되지 않고 디버그가 출력되고 파괴됩니다.
    // 3. 오브젝트가 바로 파괴됩니다.
    // >> 정답 : 2. play 문법은 거치지만 destroy가 되기 때문에 미처 출력되지 않고 넘어감

}
