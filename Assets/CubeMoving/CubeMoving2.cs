using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving2 : MonoBehaviour
{
    public float speed = 0.05f;  //�������� ��������
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
            if(TimeAct == 135)
                targe= false;
            else
            {
                transform.Translate(Vector3.back * speed);
        
                TimeAct++;
            }
        }
        else if(!targe)
        {
            if (TimeAct == -150)
                targe = true;
            else
            {
                transform.Translate(Vector3.forward * speed);
              
                TimeAct--;
            }
            
            
        }    
    }


}
