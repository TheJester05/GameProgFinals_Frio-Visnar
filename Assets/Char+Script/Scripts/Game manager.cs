using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Flag to control teleportation
    public bool currentlyTeleporting = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
