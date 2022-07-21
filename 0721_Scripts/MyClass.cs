using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass
{
    // 새로운 C# 파일로 MyClass 만드세요.
    // MyClass의 내용은 이름, 위치정보, 번호
    // 기능은 1) 생성자에서 이름, 위치, 번호를 다 매개변수로 받기
    //       2) 이름, 위치, 번호를 로그로 찍어주는 메소드

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
        Debug.Log("내 이름은 " + name);
        Debug.Log($"내 위치는 ({myPos.pos.x}, {myPos.pos.y}, {myPos.pos.z})");
        Debug.Log("내 번호는 " + number);
    }
}
