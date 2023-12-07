using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int score = 0; //����
    public Text score_text;//����� �����
    public int save_point;//����� ����������
    [SerializeField] private float rollspeed = 3; //�������� ��������
    private bool is_moving; //��������� ��������

    void Start()
    {


    }

   
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.LeftArrow)) Assemble(Vector3.forward); //�������� �����
        if (Input.GetKeyUp(KeyCode.RightArrow)) Assemble(Vector3.back); //�������� ������
        if (Input.GetKeyUp(KeyCode.UpArrow)) Assemble(Vector3.right); //�������� ������
        if (Input.GetKeyUp(KeyCode.DownArrow)) Assemble(Vector3.left); //�������� �����

        void Assemble(Vector3 dir) //������� ��������� ��� ��������
        {
            var achor = transform.position + (Vector3.down + dir) * 0.5f;
            var axis = Vector3.Cross(Vector3.up, dir);
            StartCoroutine(Roll(achor, axis));
        }



        if(transform.position.y<=-3) 
        {
            // transform.Translate(11f, 2f, 1f);
            Quaternion quaternion= Quaternion.identity;
            Vector3 ffr=Vector3.one;
            
            ffr.Set(-5.660017f, 1.225822f, -10.80998f);
            transform.SetLocalPositionAndRotation(ffr, quaternion);
        }
    }


    IEnumerator Roll(Vector3 anchor, Vector3 axis) //������� ��������
    {
        is_moving = true;

        for (int i = 0; i < (90 / rollspeed); i++)
        {
            transform.RotateAround(anchor, axis, rollspeed);
            yield return new WaitForSeconds(0.01f);
        }
        is_moving = false;

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "EndGame") //������� ����� ���� - ����������� � ������
        {
    
            Quaternion quaternion = Quaternion.identity;
            Vector3 ffr = Vector3.one;

            ffr.Set(-5.660017f, 1.225822f, -10.80998f);
            transform.SetLocalPositionAndRotation(ffr, quaternion);
        }

        else if (collision.gameObject.name == "Cylinder")  //������������� � ������� �������
        {
        
            Quaternion quaternion = Quaternion.Euler(0,0,0);
            Vector3 ffr = Vector3.one;

            ffr.Set(-13.21286f, 9.43f, 4.93f);
            transform.SetLocalPositionAndRotation(ffr, quaternion);
        }


        else if (collision.gameObject.name == "star(Clone)") //���� ��������� � ���������� �����
        {
            
            Destroy(collision.gameObject);
            score++;
            score_text.text = "����:"+score.ToString();

        }


    }

}
