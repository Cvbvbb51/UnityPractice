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
        //등속 이동, 매개변수(인수)는 (현재 위치, 목표 위치, 속도)
        //movetowards를 이용하면 객체를 한 위치에서 다른 위치로 일정한 속도로 이동시킬 수 있음.

        //2.SmoothDamp
        //Vector3 velo = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        //매개변수는 (현재 위치, 목표 위치, 참조 속도, 속도)

        //3.Lerp (선형 보간)
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        //4.SLerp (구면 선형 보간)
        //transform.position=Vector3.Slerp(transform.position, target, 0.05f);
    }
}
