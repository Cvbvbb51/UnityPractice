using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    private void Start()
    {
        //=======================================오브젝트 이동=====================================
        //게임 오브젝트는 Transform과 1:1 관계, 유니티에서 기본적으로 제공하기 때문에 따로 선언할 필요가 없다.
        //즉 오브젝트는 변수 transform을 항상 가지고 있음.
        Vector3 vec = new Vector3(0, 0, 0); //방향(x,y,z)과 크기(0,0,0)를 모두 가짐 : 벡터 값
        transform.Translate(vec); //괄호 안에 들어가는 벡터 값을 현재 위치에 더하는 함수
        //해석 : Translate(vec) : vec 만큼 이동해 주세요 (x축으로 5만큼)
        //int number = 4; //스칼라 값

        //vector3 : 3차원, vector2 : 2차원
    }
    private void Update()
    {
        //if (Input.anyKeyDown)
        //{
        //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        //}
        //===========Edit -> Project Settins -> Input Manager 에서 어떤 키를 입력 받을지 리스트가 있다.=============
        //  if (Input.anyKey)
        //   {
        //      Debug.Log("플레이어가 아무 키를 누르고 있습니다..");
        //  }

        //if (Input.GetKeyDown(KeyCode.Return))  //Return 은 키패드의 Enter를 뜻함 Keycode.W 뭐 다 가능
        //{
        //    Debug.Log("아이템을 구입하였습니다.");
        //}

        //if (Input.GetKey(KeyCode.LeftArrow)) //Arrow는 방향키
        //{
        //    Debug.Log("왼쪽으로 이동 중");
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    Debug.Log("오른쪽 이동을 멈추었습니다.");
        //}

        //if (Input.GetMouseButtonDown(0)) // 매개변수를 숫자로 받음 대표적으로 0,1 (0은 마우스 왼쪽, 1은 마우스 오른쪽)
        //{
        //    Debug.Log("미사일 발사!");
        //}

        //if (Input.GetMouseButton(0)) 
        //{
        //    Debug.Log("미사일 모으는 중...");
        //}

        //if (Input.GetMouseButtonUp(0)) 
        //{
        //    Debug.Log("슈퍼 미사일 발사!!");
        //}
        //if (Input.GetButtonDown("Jump"))
        //{
        //    Debug.Log("점프!");
        //}
        //if (Input.GetButton("Jump"))
        //{
        //    Debug.Log("점프 모으는 중 ...");
        //}
        //if (Input.GetButtonUp("Jump"))
        //{
        //    Debug.Log("슈퍼 점프!!");
        //}
        //만약 내가 원하는 키를 입력 받고 싶다. -> 추가해서 내가 임의로 설정하면 된다.

        //if (Input.GetButton("Horizontal"))
        //{
        //    Debug.Log("횡 이동 중 ..." + Input.GetAxisRaw("Horizontal"));
        //    //GetAxis : 수평, 수직 버튼 입력을 받으면 float
        //    //GetAxis와 GetAxisRaw의 차이점 : 부드러운 입력 변화(가속&감속) vs 빠른 반응성(원시 입력)
        //}
        //if (Input.GetButtonUp("Horizontal"))
        //{
        //    Debug.Log("슈퍼 점프!!");
        //}
        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"), 0);
        //transform.Translate(vec);


        /*Time.deltaTime 사용하는방법
         * deltaTime 이란 ? 이동 속도가 프레임 속도에 영향을 받지 않고 항상 일정하게 유지해주는 기능
         * 프레임 속도가 빠르면(성능이 좋으면) deltaTime이 작아져 이동거리가 줄고, 
         * 프레임 속도가 느리면(성능이 안 좋으면) deltaTime이 커져 이동거리가 는다.
         *  Translate : 벡터에 곱하기
         *  transform.Translate(Vec * Time.deltaTime);
         *  
         *  Vector 함수 : 시간 매개변수에 곱하기
         *  Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
         *  */
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, 
            Input.GetAxis("Vertical") * Time.deltaTime, 0); 
        transform.Translate(vec);
    }
    


}
    
    

