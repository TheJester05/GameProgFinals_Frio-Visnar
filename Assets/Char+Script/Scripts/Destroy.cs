using UnityEngine;
using TMPro;

public class DestroyOnTouch : MonoBehaviour
{
    public string playerTag = "Player";
    public TMP_Text remainingObjectsText;

    private static int remainingObjects;

    void Start()
    {
        
        if (remainingObjectsText == null)
        {
            Debug.LogError("RemainingObjectsText is not assigned.");
            return;
        }

        
        SetRemainingObjects(9);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            remainingObjects--;
            UpdateRemainingObjectsText();
            Destroy(gameObject);
        }
    }

    private void UpdateRemainingObjectsText()
    {
        if (remainingObjectsText != null)
        {
            remainingObjectsText.text = "Essentials for college left: " + remainingObjects;
            Debug.Log("Remaining objects updated to: " + remainingObjects);
        }
    }

    public void SetRemainingObjects(int count)
    {
        remainingObjects = count;
        Debug.Log("SetRemainingObjects called. New count: " + count);
        UpdateRemainingObjectsText();
    }
}


