using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        //1.MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f);
        //��� �̵�, �Ű�����(�μ�)�� (���� ��ġ, ��ǥ ��ġ, �ӵ�)
        //movetowards�� �̿��ϸ� ��ü�� �� ��ġ���� �ٸ� ��ġ�� ������ �ӵ��� �̵���ų �� ����.

        //2.SmoothDamp
        //Vector3 velo = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        //�Ű������� (���� ��ġ, ��ǥ ��ġ, ���� �ӵ�, �ӵ�)

        //3.Lerp (���� ����)
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        //4.SLerp (���� ���� ����)
        //transform.position=Vector3.Slerp(transform.position, target, 0.05f);
    }
}
