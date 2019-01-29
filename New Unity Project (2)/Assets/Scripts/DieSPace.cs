
using UnityEngine;


public class DieSPace : MonoBehaviour
{
    public GameObject Spawnpoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = Spawnpoint.transform.position;

        }
    }


}
