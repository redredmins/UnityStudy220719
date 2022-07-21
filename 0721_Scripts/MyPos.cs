using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MyPos
{
    // 새로운 C# 파일로 MyPos 구조체를 만드시고
    // MyClass에서 위치정보를 전달할 때 활용하세요.
    // 위치정보는 위치 이름, 위치 벡터(Vector3)값을 가짐.

    public string name;
    public Vector3 pos;

    public MyPos(string name, float x, float y, float z)
    {
        this.name = name;
        this.pos = new Vector3(x, y, z);
    }
}