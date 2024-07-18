using UnityEngine;

public class Teleporter2 : MonoBehaviour
{
    public GameObject destination; // Set this to the other teleporter's GameObject

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Replace "Player" with your player's tag
        {
            collision.transform.position = destination.transform.position;
        }
    }
}

