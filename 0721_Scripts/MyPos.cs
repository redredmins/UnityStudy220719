using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MyPos
{
    // ���ο� C# ���Ϸ� MyPos ����ü�� ����ð�
    // MyClass���� ��ġ������ ������ �� Ȱ���ϼ���.
    // ��ġ������ ��ġ �̸�, ��ġ ����(Vector3)���� ����.

    public string name;
    public Vector3 pos;

    public MyPos(string name, float x, float y, float z)
    {
        this.name = name;
        this.pos = new Vector3(x, y, z);
    }
}