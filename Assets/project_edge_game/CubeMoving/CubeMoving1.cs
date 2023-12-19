using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving1 : MonoBehaviour
{
    public float speed = 0.025f;  //скорость движения
    public float TimeAct = 0;  //скорость движения
    public bool targe = true;  //скорость движения

    // Start is called before the first frame update
    void Start()
    {

    }

    // движение первого куба
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
