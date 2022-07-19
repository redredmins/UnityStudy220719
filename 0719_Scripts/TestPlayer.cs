using System;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    // 플레이어
    // HP, MP, Stamina, Inventory, AP, DP, WalkSpeed, CriticalRate
    // 스킬명, 등급, 로그인을 한 사용자인가?

    // (전역) 변수
    // [접근지정자] [변수타입] [변수이름]; : 변수 선언
    // [값을 바꾸고싶은 변수] = [바꿀 값]; : 변수에 값 대입

    // 접근지정자 (캡슐화)
    // public : 다른 클래스 접근 가능(유니티 에디터상에서 편집 가능)
    // private : 다른 클래스에서 접근 불가능
    // protected : 자식 클래스에서만 접근 가능
    public string playerName;
    private int hp = 100; // 선언과 대입이 동시에
    int mp = 300;
    float walkSpeed = 1.23f;
    string skillName = "밤의 황제 홍민우";
    char grade = 'A';
    bool isLogin = true; // or false

    // 메서드 선언
    // [리턴값타입] [메서드이름]([파라미터변수타입] [변수이름])
    // {
    //      // 메서드 내용
    // }

    void IntroduceSelf()
    {
        IntroduceSelf(playerName);
    }

    // 자기소개 하는 메서드
    void IntroduceSelf(string selfName)
    {
        if (isLogin)
        {
            Debug.Log("내 이름은 " + selfName);
            Debug.Log(string.Format("나는 Hp가 {0} Mp는 {1}입니다.", hp, mp));
        }
        else
        {
            Debug.Log("로그인이 필요한 기능입니다.");
        }
        
    }

    void Start() // 게임오브젝트가 처음 생성될 때 한번 실행
    {
        // 메서드를 호출
        // [메서드명]([파라메터값]);
        IntroduceSelf();

        // 지역변수
        /*
        int oneDamage = hp / 10 + 1;
        while(hp > 0) // 플레이어가 살아있는 동안 반복
        {
            Attacked(oneDamage);
        }

        // 반복문
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("i 는 " + i);
            Attacked(oneDamage);
        }
        */
    }

    // 공격 당하는 메서드
    void Attacked(int damage)
    {
        Debug.Log(damage + "만큼 공격을 받았습니다.");

        // 연산자
        // + 덧셈, - 뺄셈, * 곱하기, / 나누기
        // % 나누고 난 나머지 ex) bool isRight = (100 % 3 == 1);
        hp = hp - damage;
        Debug.Log("현재 HP : " + hp);

        // 비교연산자
        // <, >, <=, >=, ==
        if (hp <= 0)
        {
            hp = 0;
            Debug.Log("캐릭터가 사망했습니다.");
        }
    }
}
