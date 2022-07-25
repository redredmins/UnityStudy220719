using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ItemInfo
{
    public int uid;
    public string itemName;
    public char grade;
    public int maxCount;
}

public class ArrayStudy : MonoBehaviour
{
    // Array(�迭) : ���� �ڷ����� ������ ������ ���
    //              ����Ÿ��, �� �޸�, GC ���� ���

    // �迭�� �ε��� ��ȣ :          0    1    2
    int[] intArray = new int[3] { 123, 456, 789 };
    public string[] monsters;

    // List : �迭�� �޸� ����� ������ ���������� ��� ����
    List<float> floatList;

    // Dictionary : Ű�� ���� �� ������ ������ �� ����
    Dictionary<string, char> gradeOfItem;
    Dictionary<int, ItemInfo> itemTable;

    private void Start()
    {
        gradeOfItem = new Dictionary<string, char>();
        gradeOfItem.Add("�ʺ����� ��", 'D');
        gradeOfItem.Add("������ ����", 'S');

        foreach(var item in gradeOfItem)
        {
            Debug.Log(item.Key + "�� ����� " + item.Value);
        }

        if (gradeOfItem.ContainsKey("������ ����"))
        {
            Debug.Log("������ ���д� " + gradeOfItem["������ ����"] + " ����Դϴ�.");
        }
    }

    void UseList()
    {
        floatList = new List<float>();
        floatList.Add(1.23f);
        floatList.Add(3.14f);
        floatList.Add(5.678f);
        floatList.Add(0f);
        floatList.Add(-1f);
        floatList.Add(floatList[0]);

        for (int i = 0; i < floatList.Count; i++)
        {
            Debug.Log("List�� " + i + "��° ��Ҵ� " + floatList[i]);
        }

        floatList.Clear();
    }

    void UseArray()
    {
        /*
        foreach(string monster in monsters)
        {
            Debug.Log(monster + " ��ȯ!");
        }

        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log("intArray�� " + i + "��° ���� " + intArray[i]);
        }
        */
    }
}
