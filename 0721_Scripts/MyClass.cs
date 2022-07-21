using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass
{
    // ���ο� C# ���Ϸ� MyClass ���弼��.
    // MyClass�� ������ �̸�, ��ġ����, ��ȣ
    // ����� 1) �����ڿ��� �̸�, ��ġ, ��ȣ�� �� �Ű������� �ޱ�
    //       2) �̸�, ��ġ, ��ȣ�� �α׷� ����ִ� �޼ҵ�

    string name;
    MyPos myPos;
    int number;

    public MyClass(string name, MyPos pos, int number)
    {
        this.name = name;
        this.myPos = pos;
        this.number = number;
    }

    public void ShowLog()
    {
        Debug.Log("�� �̸��� " + name);
        Debug.Log($"�� ��ġ�� ({myPos.pos.x}, {myPos.pos.y}, {myPos.pos.z})");
        Debug.Log("�� ��ȣ�� " + number);
    }
}
