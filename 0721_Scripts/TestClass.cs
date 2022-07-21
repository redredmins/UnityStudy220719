using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass
{
    public int testInt = 123;
    string logName;


    // ������
    public TestClass(string name) : this(name, 0) { }

    // ������ �����ε�
    public TestClass(string name, int testInt)
    {
        logName = name;
        this.testInt = testInt;
    }

    public void ShowLog(TestStruct test)
    {
        Debug.Log($"����ü ������ ? a:{test.a} / b:{test.b} / c:{test.c}");
    }

    public void ShowLog()
    {
        Debug.Log(logName + "�� �α��Դϴ�.");
        Debug.Log("testInt ���� ? " + testInt);
    }

    public void ShowTestLog()
    {
        Debug.Log("Test!!!");
    }
}