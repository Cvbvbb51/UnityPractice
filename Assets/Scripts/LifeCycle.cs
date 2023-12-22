using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    private void Start()
    {
        //=======================================������Ʈ �̵�=====================================
        //���� ������Ʈ�� Transform�� 1:1 ����, ����Ƽ���� �⺻������ �����ϱ� ������ ���� ������ �ʿ䰡 ����.
        //�� ������Ʈ�� ���� transform�� �׻� ������ ����.
        Vector3 vec = new Vector3(0, 0, 0); //����(x,y,z)�� ũ��(0,0,0)�� ��� ���� : ���� ��
        transform.Translate(vec); //��ȣ �ȿ� ���� ���� ���� ���� ��ġ�� ���ϴ� �Լ�
        //�ؼ� : Translate(vec) : vec ��ŭ �̵��� �ּ��� (x������ 5��ŭ)
        //int number = 4; //��Į�� ��

        //vector3 : 3����, vector2 : 2����
    }
    private void Update()
    {
        //if (Input.anyKeyDown)
        //{
        //    Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        //}
        //===========Edit -> Project Settins -> Input Manager ���� � Ű�� �Է� ������ ����Ʈ�� �ִ�.=============
        //  if (Input.anyKey)
        //   {
        //      Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�..");
        //  }

        //if (Input.GetKeyDown(KeyCode.Return))  //Return �� Ű�е��� Enter�� ���� Keycode.W �� �� ����
        //{
        //    Debug.Log("�������� �����Ͽ����ϴ�.");
        //}

        //if (Input.GetKey(KeyCode.LeftArrow)) //Arrow�� ����Ű
        //{
        //    Debug.Log("�������� �̵� ��");
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    Debug.Log("������ �̵��� ���߾����ϴ�.");
        //}

        //if (Input.GetMouseButtonDown(0)) // �Ű������� ���ڷ� ���� ��ǥ������ 0,1 (0�� ���콺 ����, 1�� ���콺 ������)
        //{
        //    Debug.Log("�̻��� �߻�!");
        //}

        //if (Input.GetMouseButton(0)) 
        //{
        //    Debug.Log("�̻��� ������ ��...");
        //}

        //if (Input.GetMouseButtonUp(0)) 
        //{
        //    Debug.Log("���� �̻��� �߻�!!");
        //}
        //if (Input.GetButtonDown("Jump"))
        //{
        //    Debug.Log("����!");
        //}
        //if (Input.GetButton("Jump"))
        //{
        //    Debug.Log("���� ������ �� ...");
        //}
        //if (Input.GetButtonUp("Jump"))
        //{
        //    Debug.Log("���� ����!!");
        //}
        //���� ���� ���ϴ� Ű�� �Է� �ް� �ʹ�. -> �߰��ؼ� ���� ���Ƿ� �����ϸ� �ȴ�.

        //if (Input.GetButton("Horizontal"))
        //{
        //    Debug.Log("Ⱦ �̵� �� ..." + Input.GetAxisRaw("Horizontal"));
        //    //GetAxis : ����, ���� ��ư �Է��� ������ float
        //    //GetAxis�� GetAxisRaw�� ������ : �ε巯�� �Է� ��ȭ(����&����) vs ���� ������(���� �Է�)
        //}
        //if (Input.GetButtonUp("Horizontal"))
        //{
        //    Debug.Log("���� ����!!");
        //}
        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"), 0);
        //transform.Translate(vec);


        /*Time.deltaTime ����ϴ¹��
         * deltaTime �̶� ? �̵� �ӵ��� ������ �ӵ��� ������ ���� �ʰ� �׻� �����ϰ� �������ִ� ���
         * ������ �ӵ��� ������(������ ������) deltaTime�� �۾��� �̵��Ÿ��� �ٰ�, 
         * ������ �ӵ��� ������(������ �� ������) deltaTime�� Ŀ�� �̵��Ÿ��� �´�.
         *  Translate : ���Ϳ� ���ϱ�
         *  transform.Translate(Vec * Time.deltaTime);
         *  
         *  Vector �Լ� : �ð� �Ű������� ���ϱ�
         *  Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
         *  */
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, 
            Input.GetAxis("Vertical") * Time.deltaTime, 0); 
        transform.Translate(vec);
    }
    


}
    
    

