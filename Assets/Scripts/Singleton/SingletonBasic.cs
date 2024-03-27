using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 싱글톤 패턴(Singleton Pattern)
클래스의 객체를 하나만 생성하도록 설계하는 패턴
그 하나의 객체를 참조해 어디서든 사용이 가능하도록 하는 패턴
유니티에서는 주로 XXXController, XXXManager 등의 구현에 해당 패턴을 자주 사용함

싱글톤 패턴은 static 키워드를 활용한 기능으로 전역 변수를 사용하게 되는 개념입니다.
따라서 전역 변수의 문제인 메모리 부족, 멀티태스킹 환경에서 오류 발생, 코드 리팩토링(수정) 과저에서
해당 전역 변수 사용 중단 시 모든 모듈 수정 등의 단점을 그대로 가지게 됩니다.

// 싱글톤 사용 시 적절한 상황 판단
1. 범용성이 적어서 특정 클래스에만 쓰이는 코드일 경우 싱글톤으로 구현하지 않고 그 클래스에 그 코드를 넣는 것이 더 이득입니다.
   유니티에서 제공되는 기능이 있다면 그 기능으로 해결하는 것이 더 나을 수 있습니다.

// 장점
다른 클래스와는 독립적으로 유지됨.
객체 접근에 매우 용이함. (전역)
불필요한 중복 설계를 피할 수 있습니다. 이는 메모리의 낭비를 막는 효과를 가져옵니다.


*/

public class SingletonBasic : MonoBehaviour
{
    // 구현 방법
    // 1. 외부에서 접근할 수 없으며, 정적 형태의 클래스 객체를 가지고 있습니다.
    private static SingletonBasic instance = null;

    // 2. 생성자를 통해 생성하는 것이 불가능합니다.
    private SingletonBasic() { }

    // 3. 메소드나 프로퍼티를 통해 접근이 가능하도록 설계하며, 객체가 없는 경우
    // 객체를 생성하고 일반적인 경우에는 만들어진 객체를 return하도록 설계합니다.
    // 보통은 프로퍼티를 통해 편하게 설계하고자 한다.
    // 아래 두 메소드는 같은 기능을 수행함.
    public static SingletonBasic Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new SingletonBasic();
            }
            return instance;
        }
    }

    public static SingletonBasic GetInstance()
    {
        if (instance == null)
        {
            instance = new SingletonBasic();
        }
        return instance;
    }

}
