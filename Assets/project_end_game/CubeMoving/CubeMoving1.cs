using UnityEngine;

public class CubeMoving1 : MonoBehaviour
{
    public float speed = 0.025f; 
    public float TimeAct = 0;  
    public bool targe = true;  
    public int number_cube;

    void FixedUpdate()
    {
        //moving cube 1
        if (number_cube == 1)
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
        //moving cube 2
        if (number_cube == 2)
        {
            if (targe)
            {
                if (TimeAct == 135)
                    targe = false;
                else
                {
                    transform.Translate(Vector3.back * speed);

                    TimeAct++;
                }
            }
            else if (!targe)
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
}
