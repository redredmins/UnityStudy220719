using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // ���� :
    //  ���� �̸�, Ű/������ <- �����Ϳ��� ���� �����ϰ�
    //  ���ݷ�, HP, ����, ���, �ڵ������� �ϴ���?

    // �޼��� :
    //   1) �ڱ�Ұ� : �����ִ� ������ �� �� �˷��ֱ�
    //   2) �÷��̾ ������ �� : �ڵ����� ���ε��� �ൿ �޶�����
    //   3) �����ϱ� : Hp ���̰� / ��޿� ���� �ٸ� ���� �ϱ�
    //   4) ����

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
        monType = "��ũ";
        grade = 'B';
        canAutoAttack = true;

        IntroduceSelf();

        Invoke("OnPlayerMeet", 3.5f);
    }

    void IntroduceSelf()
    {
        string self1 =
            string.Format("���� {0}�Դϴ�.\nŰ {1}, ������ {2}������.",
                monName, height, weight);
        string self2 =
            string.Format("\n����Ÿ�� {2} / ���ݷ� {0} / HP {1}\n",
                ap, hp, monType);
        string canAutoText = (canAutoAttack) ? "����" : "�Ұ���";
        string self3 =
            grade + "��޿� �ڵ������� " + canAutoText + "�մϴ�.";

        Debug.Log(self1 + self2 + self3);
    }

    void OnPlayerMeet()
    {
        if (canAutoAttack == true)
        {
            Debug.Log("���Ͱ� �÷��̾ �߰��ϰ� �ڵ������� �����մϴ�.");
            Attack();
        }
        else
        {
            Debug.Log("���Ͱ� �÷��̾ �߰��ϰ� �������ϴ�.");
        }
    }

    void Attack()
    {
        int damage = 0;
        switch(grade)
        {
            case 'A':
                Debug.Log("������ ������ �ߴ�!!!");
                damage = 100;
                break;

            case 'B':
            case 'C':
                Debug.Log("����� ������ �ߴ�!");
                damage = 50;
                break;

            default:
                Debug.Log("������ �ߴ�.");
                damage = 10;
                break;
        }

        //hp = hp - damage;
        hp -= damage;
        Debug.Log($"�ݰ��� ���� HP�� {damage}��ŭ �𿴽��ϴ�.");

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
