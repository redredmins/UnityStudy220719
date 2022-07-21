using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    int a = 124; // �� Ÿ�� (���� �޸�, GC�� ����)
    float b;
    // ��Ÿ�� : char, bool, byte, int, float

    TestClass test = null; // ���� Ÿ�� (�� �޸�, GC�� ����)
    
    void Start()
    {
        // ���ο� C# ���Ϸ� MyClass ���弼��.
        // MyClass�� ������ �̸�, ��ġ����, ��ȣ
        // ����� 1) �����ڿ��� �̸�, ��ġ, ��ȣ�� �� �Ű������� �ޱ�
        //       2) �̸�, ��ġ, ��ȣ�� �α׷� ����ִ� �޼ҵ�

        // ���ο� C# ���Ϸ� MyPos ����ü�� ����ð�
        // MyClass���� ��ġ������ ������ �� Ȱ���ϼ���.
        // ��ġ������ ��ġ �̸�, ��ġ ���Ͱ��� ����.

        // TestManager�� Start �޼ҵ忡�� MyClass �ν��Ͻ� �����ϰ�
        // �α� ����
    }

    void Test()
    {
        test = new TestClass("�׽�Ʈ 1"); // �ν��Ͻ� ����
        test.ShowTestLog();
        test.testInt = 456;
        test.ShowLog();

        TestClass test2 = new TestClass("�׽�Ʈ 2");
        test2.testInt = 9999;
        test2.ShowLog();

        TestClass test3 = test;
        test3.ShowLog();

        test2 = null; // �ι�° �ν��Ͻ��� �����ϴ� ������ ���� ������
                      // GC�� ���� ����� ��.

        TestClass test4 = new TestClass("�׽�Ʈ 4", 777);
        test4.ShowLog();
        test4.ShowLog(new TestStruct(66, 3.14f, true));
    }
}
