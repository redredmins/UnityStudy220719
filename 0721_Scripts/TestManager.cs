using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    int a = 124; // 값 타입 (스텍 메모리, GC와 무관)
    float b;
    // 값타입 : char, bool, byte, int, float

    TestClass test = null; // 참조 타입 (힙 메모리, GC가 관리)
    
    void Start()
    {
        // TestManager의 Start 메소드에서 MyClass 인스턴스 생성하고
        // 로그 찍어보기

        var mp = new MyPos("내위치", 1f, 0.5f, -20f);
        MyClass mc = new MyClass("마이클래스", mp, 3);

        mc.ShowLog();
    }

    void Test()
    {
        test = new TestClass("테스트 1"); // 인스턴스 생성
        test.ShowTestLog();
        test.testInt = 456;
        test.ShowLog();

        TestClass test2 = new TestClass("테스트 2");
        test2.testInt = 9999;
        test2.ShowLog();

        TestClass test3 = test;
        test3.ShowLog();

        test2 = null; // 두번째 인스턴스는 참조하는 변수가 없기 때문에
                      // GC의 수거 대상이 됨.

        TestClass test4 = new TestClass("테스트 4", 777);
        test4.ShowLog();
        test4.ShowLog(new TestStruct(66, 3.14f, true));
    }
}
