using System;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    // �÷��̾�
    // HP, MP, Stamina, Inventory, AP, DP, WalkSpeed, CriticalRate
    // ��ų��, ���, �α����� �� ������ΰ�?

    // (����) ����
    // [����������] [����Ÿ��] [�����̸�]; : ���� ����
    // [���� �ٲٰ���� ����] = [�ٲ� ��]; : ������ �� ����

    // ���������� (ĸ��ȭ)
    // public : �ٸ� Ŭ���� ���� ����(����Ƽ �����ͻ󿡼� ���� ����)
    // private : �ٸ� Ŭ�������� ���� �Ұ���
    // protected : �ڽ� Ŭ���������� ���� ����
    public string playerName;
    private int hp = 100; // ����� ������ ���ÿ�
    int mp = 300;
    float walkSpeed = 1.23f;
    string skillName = "���� Ȳ�� ȫ�ο�";
    char grade = 'A';
    bool isLogin = true; // or false

    // �޼��� ����
    // [���ϰ�Ÿ��] [�޼����̸�]([�Ķ���ͺ���Ÿ��] [�����̸�])
    // {
    //      // �޼��� ����
    // }

    void IntroduceSelf()
    {
        IntroduceSelf(playerName);
    }

    // �ڱ�Ұ� �ϴ� �޼���
    void IntroduceSelf(string selfName)
    {
        if (isLogin)
        {
            Debug.Log("�� �̸��� " + selfName);
            Debug.Log(string.Format("���� Hp�� {0} Mp�� {1}�Դϴ�.", hp, mp));
        }
        else
        {
            Debug.Log("�α����� �ʿ��� ����Դϴ�.");
        }
        
    }

    void Start() // ���ӿ�����Ʈ�� ó�� ������ �� �ѹ� ����
    {
        // �޼��带 ȣ��
        // [�޼����]([�Ķ���Ͱ�]);
        IntroduceSelf();

        // ��������
        /*
        int oneDamage = hp / 10 + 1;
        while(hp > 0) // �÷��̾ ����ִ� ���� �ݺ�
        {
            Attacked(oneDamage);
        }

        // �ݺ���
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("i �� " + i);
            Attacked(oneDamage);
        }
        */
    }

    // ���� ���ϴ� �޼���
    void Attacked(int damage)
    {
        Debug.Log(damage + "��ŭ ������ �޾ҽ��ϴ�.");

        // ������
        // + ����, - ����, * ���ϱ�, / ������
        // % ������ �� ������ ex) bool isRight = (100 % 3 == 1);
        hp = hp - damage;
        Debug.Log("���� HP : " + hp);

        // �񱳿�����
        // <, >, <=, >=, ==
        if (hp <= 0)
        {
            hp = 0;
            Debug.Log("ĳ���Ͱ� ����߽��ϴ�.");
        }
    }
}
