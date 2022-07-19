using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // 변수 :
    //  몬스터 이름, 키/몸무게 <- 에디터에서 수정 가능하게
    //  공격력, HP, 종류, 등급, 자동공격을 하는지?

    // 메서드 :
    //   1) 자기소개 : 갖고있는 변수의 값 다 알려주기
    //   2) 플레이어를 만났을 때 : 자동공격 여부따라 행동 달라지게
    //   3) 공격하기 : Hp 깎이게 / 등급에 따라 다른 공격 하기
    //   4) 죽음

    public string monName;
    public float height, weight;
    int hp, ap;
    string monType;
    char grade;
    bool canAutoAttack;

    void Start()
    {
        hp = 1000;
        ap = 30;
        monType = "오크";
        grade = 'B';
        canAutoAttack = true;

        IntroduceSelf();

        Invoke("OnPlayerMeet", 3.5f);
    }

    void IntroduceSelf()
    {
        string self1 =
            string.Format("나는 {0}입니다.\n키 {1}, 몸무게 {2}이지요.",
                monName, height, weight);
        string self2 =
            string.Format("\n공격타입 {2} / 공격력 {0} / HP {1}\n",
                ap, hp, monType);
        string canAutoText = (canAutoAttack) ? "가능" : "불가능";
        string self3 =
            grade + "등급에 자동공격이 " + canAutoText + "합니다.";

        Debug.Log(self1 + self2 + self3);
    }

    void OnPlayerMeet()
    {
        if (canAutoAttack == true)
        {
            Debug.Log("몬스터가 플레이어를 발견하고 자동공격을 시작합니다.");
            Attack();
        }
        else
        {
            Debug.Log("몬스터가 플레이어를 발견하고 지나갑니다.");
        }
    }

    void Attack()
    {
        int damage = 0;
        switch(grade)
        {
            case 'A':
                Debug.Log("굉장한 공격을 했다!!!");
                damage = 100;
                break;

            case 'B':
            case 'C':
                Debug.Log("평범한 공격을 했다!");
                damage = 50;
                break;

            default:
                Debug.Log("공격을 했다.");
                damage = 10;
                break;
        }

        //hp = hp - damage;
        hp -= damage;
        Debug.Log($"반격을 당해 HP가 {damage}만큼 깎였습니다.");

        /*
        if (grade == 'A')
        {

        }
        else if (grade == 'B')
        {

        }
        else
        {

        }
        */
    }


}
