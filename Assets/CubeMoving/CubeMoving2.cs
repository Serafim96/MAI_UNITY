using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving2 : MonoBehaviour
{
    public float speed = 0.05f;  //скорость движения
    public float TimeAct = 0;  //скорость движения
    public bool targe = true;  //скорость движения
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // движение второго куба
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
