using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player; //  object player
    private Vector3 offset; 
    
    void Start()
    {
        offset = transform.position - player.transform.position; //calculate different position camera and player
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;//change camera position
    }
}
