using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    private Collider2D Collider;
    [SerializeField]
    private ContactFilter2D Filter;
    private List<Collider2D> CollidedObjects = new List<Collider2D>(1);

    protected virtual void Start()
    {
        Collider = GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        Collider.OverlapCollider(Filter,CollidedObjects);
        foreach(var o in CollidedObjects)
        {
            OnCollided(o.gameObject);
        }
    }
    protected virtual void OnCollided(GameObject collidedObject)
    {
        Debug.Log("Collided with" + collidedObject.name);
    }
}
