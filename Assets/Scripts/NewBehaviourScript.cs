using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("Hello Unity!");
        
        //1. ����
        int level = 5;
        float strength = 15.5f;
        string playerName = "���˻�";
        bool isFullLevel = false;

        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);

        //2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ������ ����");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");
            
        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);


        //������
        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        

    }

    
}
