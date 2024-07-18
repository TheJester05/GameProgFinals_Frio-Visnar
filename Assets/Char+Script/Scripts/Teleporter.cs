using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject destination;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !GameManager.instance.currentlyTeleporting)
        {
            GameManager.instance.currentlyTeleporting = true;

            // Stop player movement
            PlayerController playerController = collision.GetComponent<PlayerController>();
            playerController.StopAllCoroutines();
            playerController.SetIsMoving(false);

            // Teleport player
            collision.transform.position = destination.transform.position;

            


            Invoke(nameof(ResetTeleportFlag), 1f);
        }
    }

    private void ResetTeleportFlag()
    {
        GameManager.instance.currentlyTeleporting = false;
    }
}


