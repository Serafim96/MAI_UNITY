using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 0.05f;  //�������� ��������
    public float TimeAct = 0;  //�������� ��������
    public bool targe = true;  //�������� ��������
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targe)
        {
            if(TimeAct == 135)
                targe= false;
            else
            {
                transform.Translate(Vector3.right * speed);
                TimeAct++;
            }
        }
        else if(!targe)
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
