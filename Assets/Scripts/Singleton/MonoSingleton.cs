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
                // 1. 게임 내에 MonoSingleton 형태의 오브젝트가 존재하는지 확인합니다.
                var obj = FindObjectOfType<MonoSingleton>();
                // 오브젝트가 존재한다면 인스턴스를 해당 값으로 처리합니다.
                if(obj != null)
                {
                    instance = obj;
                }
                else    // 일반적으로 이 부분이 실행될 일은 없음
                {
                    // 게임 오브젝트를 "MonoSingleton"의 이름으로 생성하고 MonoSingleton 컴포넌트를 추가합니다.
                    var newObject = new GameObject("MonoSingleton").AddComponent<MonoSingleton>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        // MonoSingleton 형태의 오브젝트들을 게임에서 조사합니다.
        var obj = FindObjectsOfType<MonoSingleton>();
        
        // 오브젝트 배열의 길이가 1이 아니라면 (유일 객체가 아닌 경우)
        if(obj.Length != 1)
        {
            Destroy(gameObject);
            return;
        }
        // 해당 코드를 작업할 경우 씬을 이동해도 유지됩니다.
        DontDestroyOnLoad(gameObject);
    }

}
