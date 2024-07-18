using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal1 : MonoBehaviour
{
    private Transform destination;

    public bool isPortal1;
    public float distance = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        if (isPortal1 == false)
        {
            destination = GameObject.FindGameObjectWithTag("portal 1").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("portal 2").GetComponent<Transform>();
        }
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)

    {
        if (Vector2.Distance(transform.position, other.transform.position) > distance )
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
        
    }
}
