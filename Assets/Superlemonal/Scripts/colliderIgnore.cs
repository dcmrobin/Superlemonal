using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class colliderIgnore : MonoBehaviour
{
    public GameObject objectToIgnore;
    // Start is called before the first frame update
    void Start()
    {
        if (objectToIgnore.GetComponent<Collider>() != null)
        {
            Physics.IgnoreCollision(objectToIgnore.GetComponent<Collider>(), gameObject.GetComponent<BoxCollider>());
        } else
        {
            Physics.IgnoreCollision(objectToIgnore.GetComponent<CharacterController>(), gameObject.GetComponent<BoxCollider>());
        }
    }
}
