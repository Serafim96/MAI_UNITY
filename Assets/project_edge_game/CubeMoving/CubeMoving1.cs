using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving1 : MonoBehaviour
{
    public float speed = 0.025f;  //�������� ��������
    public float TimeAct = 0;  //�������� ��������
    public bool targe = true;  //�������� ��������

    // Start is called before the first frame update
    void Start()
    {

    }

    // �������� ������� ����
    void FixedUpdate()
    {
        if (targe) 
        {
            if (TimeAct == 135)
                targe = false;
            else
            {
                transform.Translate(Vector3.right * speed);
                TimeAct++;
            }
        }
        else if (!targe)
        {
            if (TimeAct == -150)
                targe = true;
            else
            {
                transform.Translate(Vector3.left * speed);
                TimeAct--;
            }


        }
    }
}
