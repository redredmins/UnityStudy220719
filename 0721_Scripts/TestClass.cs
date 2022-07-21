using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass
{
    public int testInt = 123;
    string logName;


    // 생성자
    public TestClass(string name) : this(name, 0) { }

    // 생성자 오버로드
    public TestClass(string name, int testInt)
    {
        logName = name;
        this.testInt = testInt;
    }

    public void ShowLog(TestStruct test)
    {
        Debug.Log($"구조체 내용은 ? a:{test.a} / b:{test.b} / c:{test.c}");
    }

    public void ShowLog()
    {
        Debug.Log(logName + "의 로그입니다.");
        Debug.Log("testInt 값은 ? " + testInt);
    }

    public void ShowTestLog()
    {
        Debug.Log("Test!!!");
    }
}