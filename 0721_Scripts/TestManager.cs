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
        // 새로운 C# 파일로 MyClass 만드세요.
        // MyClass의 내용은 이름, 위치정보, 번호
        // 기능은 1) 생성자에서 이름, 위치, 번호를 다 매개변수로 받기
        //       2) 이름, 위치, 번호를 로그로 찍어주는 메소드

        // 새로운 C# 파일로 MyPos 구조체를 만드시고
        // MyClass에서 위치정보를 전달할 때 활용하세요.
        // 위치정보는 위치 이름, 위치 벡터값을 가짐.

        // TestManager의 Start 메소드에서 MyClass 인스턴스 생성하고
        // 로그 찍어보기
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
