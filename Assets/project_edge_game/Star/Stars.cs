using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public static GameObject[] array_stars = new GameObject[15]; //массив для звезд
    public GameObject star; //объект звезда

    void Start() //создание звезд 
    {

        array_stars[0]=Instantiate(star,new Vector3(-1,1),new Quaternion(0,0,0,0));
        array_stars[1] = Instantiate(star, new Vector3(-3, 1), new Quaternion(0, 0, 0, 0));
        array_stars[2] = Instantiate(star, new Vector3(-5, 1), new Quaternion(0, 0, 0, 0));
        array_stars[3] = Instantiate(star, new Vector3(-7, 1), new Quaternion(0, 0, 0, 0));
        array_stars[4] = Instantiate(star, new Vector3(-11, 1), new Quaternion(0, 0, 0, 0));
        array_stars[5] = Instantiate(star, new Vector3(-13, 1), new Quaternion(0, 0, 0, 0));
        array_stars[6] = Instantiate(star, new Vector3(-15, 1), new Quaternion(0, 0, 0, 0));
        array_stars[7] = Instantiate(star, new Vector3(-17, 1), new Quaternion(0, 0, 0, 0));

        array_stars[8] = Instantiate(star, new Vector3(-1, 1, -9), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-3, 1, -9), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-5, 1, -9), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-7, 1, -9), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-11, 1, -11), new Quaternion(0, 0, 0, 0));

        array_stars[8] = Instantiate(star, new Vector3(-13, 1, -11), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-15, 1, -11), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-17, 1, -11), new Quaternion(0, 0, 0, 0));
        
        array_stars[8] = Instantiate(star, new Vector3(-17, 1, -9), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-17, 1, -7), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-17, 1, -5), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-17, 1, -3), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-17, 1, -1.5f), new Quaternion(0, 0, 0, 0));

        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, -9), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, -7), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, -5), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, -3), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, -1.5f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, 2f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, 4f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-10.5f, 1, 6f), new Quaternion(0, 0, 0, 0));

        array_stars[8] = Instantiate(star, new Vector3(-1, 1, 6.6f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-3, 1, 6.6f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-5, 1, 6.6f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-7, 1, 6.6f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-9, 1, 6.6f), new Quaternion(0, 0, 0, 0));

        array_stars[8] = Instantiate(star, new Vector3(-12f, 3, 7f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-13.5f, 3, 7f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(-15f, 3, 7f), new Quaternion(0, 0, 0, 0));

        array_stars[8] = Instantiate(star, new Vector3(0.18f, 1.64f, -6.02f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(0.18f, 2.2f, -4.68f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(0.18f, 2.54f, -3.27f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(0.18f, 3.24f, -1.97f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(0.18f, 3.68f, -0.84f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(0.18f, 4.02f, -0.29f), new Quaternion(0, 0, 0, 0));
        array_stars[8] = Instantiate(star, new Vector3(0.18f, 4.77f, 1.35f), new Quaternion(0, 0, 0, 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
