using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player; //  объект игрока
    private Vector3 offset; 
    
    void Start()
    {

        offset = transform.position - player.transform.position; //вычисление разницы в положении камеры и игрока
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;//изменение положения камеры
    }
}
