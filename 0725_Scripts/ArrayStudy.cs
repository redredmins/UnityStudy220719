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
    // Array(배열) : 같은 자료형의 변수를 여러개 사용
    //              참조타입, 힙 메모리, GC 관리 대상

    // 배열의 인덱스 번호 :          0    1    2
    int[] intArray = new int[3] { 123, 456, 789 };
    public string[] monsters;

    // List : 배열과 달리 요소의 갯수를 가변적으로 사용 가능
    List<float> floatList;

    // Dictionary : 키와 값을 한 쌍으로 저장할 수 있음
    Dictionary<string, char> gradeOfItem;
    Dictionary<int, ItemInfo> itemTable;

    private void Start()
    {
        gradeOfItem = new Dictionary<string, char>();
        gradeOfItem.Add("초보자의 검", 'D');
        gradeOfItem.Add("전설의 방패", 'S');

        foreach(var item in gradeOfItem)
        {
            Debug.Log(item.Key + "의 등급은 " + item.Value);
        }

        if (gradeOfItem.ContainsKey("전설에 방패"))
        {
            Debug.Log("전설의 방패는 " + gradeOfItem["전설에 방패"] + " 등급입니다.");
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
            Debug.Log("List의 " + i + "번째 요소는 " + floatList[i]);
        }

        floatList.Clear();
    }

    void UseArray()
    {
        /*
        foreach(string monster in monsters)
        {
            Debug.Log(monster + " 소환!");
        }

        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log("intArray의 " + i + "번째 값은 " + intArray[i]);
        }
        */
    }
}
