using UnityEngine;

public class Mechanizm : MonoBehaviour
{
    public GameObject platform;
    public Player player;

    private void OnCollisionEnter(Collision collision) // change position platform
    {

        if (collision.gameObject.tag == player.tag) {
            platform.transform.position = new Vector3(-14.7f, 0.12f, 3.86f);
       
        }
    }
}
