using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct TestStruct
{
    // struct ����ü
    // class�� �޸� �� Ÿ������ ���� �޸𸮿� ����
    // �������� ����

    public int a;
    public float b;
    public bool c;

    // ������
    public TestStruct(int a, float b, bool c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
}
