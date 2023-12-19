using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanizm : MonoBehaviour
{
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) // при воздействии игрока на механизм платформа передвигается
    {
       
            if (collision.gameObject.tag == "Player") {
            platform.transform.position = new Vector3(-14.7f, 0.12f, 3.86f);
       
        }
    }
}
