using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 제네릭 클래스
// class 클래스명<T>로 구성하면 T 자리에 타입을 넣을 수 있습니다.

// 제네릭 제약 조선
// where T : struct             => T는 null을 허용하지 않는 값의 형식
// where T : class              => T는 참조(Reference) 형식
// where T : new()              => 기본 생성자가 있어야 합니다. 다른 제약 조건과 같이 쓰일 경우 가장 마지막 작성됩니다.
// where T : notnull            => T는 null이 아닌 형식, 제약 조건 위반 시 에러가 아닌 경고가 뜨게 됩니다.
// where T : (base)className    => T는 지정된 기본 클래스이거나 이 클래스에서 파생된 클래스여야 합니다.
// where T : interfaceName      => T는 지정된 기본 인터페이스이거나 이 인터페이스에서 파생된 유형이어야 합니다.

// 타입 파라미터가 2개 이상일 경우에는 제약 조건을 각각 작성하는 것이 가능합니다.
// public class MultiType<T, K> where T: struct where K : class { }


public class TSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public int value;

    private static T _instance;
    // T 자리에는 해당 클래스를 상속받는 클래스의 타입을 넣을 수 있습니다.
    // 이때 이 클래스는 MonoBehaviour 또는 MonoBehaviour를 상속받은 클래스입니다.

    private static bool _ShutDown = false;
    private static object _Lock = new object();

    // 프로퍼티는 주로 변수가 소문자로 구현될 때 앞글자만 대문자로 쓰는 경우가 많습니다.
    public static T Instance
    {
        get
        {
            // 게임 종료 시 오브젝트보다 싱글톤의 OnDestroy가 먼저 실행될 수 있는 상황에 대한 방지
            if (_ShutDown)
            {
                return null;
            }

            // C#의 lock 기능
            // 특정 블럭의 코드를 한 번에 하나의 스레드만 실행할 수 있도록 처리해주는 도구
            // 프로그램에서 공유 자원으로 사용되는 값들에 주로 사용되는 키워드입니다.
            lock(_Lock)
            {
                if(_instance == null)
                {
                    // 인스턴스가 현재 존재하는지를 체크합니다.
                    _instance = FindObjectOfType<T>();

                    // 조사를 했는데도 생성되지 않았을 경우
                    if(_instance == null)
                    {
                        // 새 오브젝트 생성
                        var sObj = new GameObject();
                        // 인스턴스 객채 T를 컴포넌트로 추가한 sObj로 할당
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
