using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int score = 0; //score
    public Text score_text;//text score
    public int save_point;//point save
    [SerializeField] private float rollspeed = 3; //speed roll
    public bool is_moving; //state move
    public GameObject star;
      void Update()
    {

        if (Input.GetKeyUp(KeyCode.LeftArrow)) Assemble(Vector3.forward); //move left
        if (Input.GetKeyUp(KeyCode.RightArrow)) Assemble(Vector3.back); //move right
        if (Input.GetKeyUp(KeyCode.UpArrow)) Assemble(Vector3.right); //move forward
        if (Input.GetKeyUp(KeyCode.DownArrow)) Assemble(Vector3.left); //move back

        void Assemble(Vector3 dir) //change position
        {
            var achor = transform.position + (Vector3.down + dir) * 0.5f;
            var axis = Vector3.Cross(Vector3.up, dir);
            StartCoroutine(Roll(achor, axis));
        }

        if(transform.position.y<=-3) 
        {
            Quaternion quaternion= Quaternion.identity;
            Vector3 ffr=Vector3.one;
            
            ffr.Set(-5.660017f, 1.225822f, -10.80998f);
            transform.SetLocalPositionAndRotation(ffr, quaternion);
        }
    }


    IEnumerator Roll(Vector3 anchor, Vector3 axis) //change rotation
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
        if (collision.gameObject.name == "EndGame") //end game
        {
    
            Quaternion quaternion = Quaternion.identity;
            Vector3 ffr = Vector3.one;

            ffr.Set(-5.660017f, 1.225822f, -10.80998f);
            transform.SetLocalPositionAndRotation(ffr, quaternion);
        }

        else if (collision.gameObject.name == "Cylinder")  //teleport
        {
        
            Quaternion quaternion = Quaternion.Euler(0,0,0);
            Vector3 ffr = Vector3.one;

            ffr.Set(-13.21286f, 9.43f, 4.93f);
            transform.SetLocalPositionAndRotation(ffr, quaternion);
        }


        else if (collision.gameObject.tag == star.tag) //give stars
        {
            
            Destroy(collision.gameObject);
            score++;
            score_text.text = "Очки:"+score.ToString();

        }


    }

}
