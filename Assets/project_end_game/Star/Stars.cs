using UnityEngine;

public class Stars : MonoBehaviour
{
    private const int NUM = 43;
    public static GameObject[] array_stars = new GameObject[NUM]; //array for stars
    public GameObject star; //object star
    public Vector3[] points;
    void Start() //create stars
    {
        points = new Vector3[NUM];

        points[0].Set(-1,1,0);
        points[1].Set(-3, 1, 0);
        points[2].Set(-7, 1, 0);
        points[3].Set(-11, 1, 0);
        points[4].Set(-13, 1, 0);
        points[5].Set(-15, 1, 0);
        points[6].Set(-17, 1, 0);
        points[7].Set(-1, 1, -9);
        points[8].Set(-3, 1, -9);
        points[9].Set(-5, 1, -9);
        points[10].Set(-7, 1, -9);
        points[11].Set(-11, 1, -11);
        points[12].Set(-13, 1, -11);
        points[13].Set(-15, 1, -11);
        points[14].Set(-17, 1, -11);
        points[15].Set(-17, 1, -9);
        points[16].Set(-17, 1, -7);
        points[17].Set(-17, 1, -5);
        points[18].Set(-17, 1, -3);
        points[19].Set(-17, 1, -1.5f);
        points[20].Set(-10.5f, 1, -9);
        points[21].Set(-10.5f, 1, -7);
        points[22].Set(-10.5f, 1, -5);
        points[23].Set(-10.5f, 1, -3);
        points[24].Set(-10.5f, 1, -1.5f);
        points[25].Set(-10.5f, 1, 2f);
        points[26].Set(-10.5f, 1, 4f);
        points[27].Set(-10.5f, 1, 6f);
        points[28].Set(-1, 1, 6.6f);
        points[29].Set(-3, 1, 6.6f);
        points[30].Set(-5, 1, 6.6f);
        points[31].Set(-7, 1, 6.6f);
        points[32].Set(-9, 1, 6.6f);
        points[33].Set(-12, 3, 7f);
        points[34].Set(-13.5f, 3, 7f);
        points[35].Set(-15f, 3, 7f);
        points[36].Set(0.18f, 1.64f, -6.02f);
        points[37].Set(0.18f, 2.2f, -4.68f);
        points[38].Set(0.18f, 2.54f, -3.27f);
        points[39].Set(0.18f, 3.24f, -1.97f);
        points[40].Set(0.18f, 3.68f, -0.84f);
        points[41].Set(0.18f, 4.02f, -0.29f);
        points[42].Set(0.18f, 4.77f, 1.357f);

        for(int i=0;i< NUM; i++)
            array_stars[0]=Instantiate(star, points[i], new Quaternion(0,0,0,0));

    }

}
