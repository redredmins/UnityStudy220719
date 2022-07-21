using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct TestStruct
{
    // struct 구조체
    // class와 달리 값 타입으로 스텍 메모리에 저장
    // 변수들의 묶음

    public int a;
    public float b;
    public bool c;

    // 생성자
    public TestStruct(int a, float b, bool c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
}
