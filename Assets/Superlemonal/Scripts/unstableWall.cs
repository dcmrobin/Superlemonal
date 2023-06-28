using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unstableWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (!other.transform.CompareTag("Player") && other.transform.GetComponent<Rigidbody>() != null)
        {
            if (gameObject.GetComponent<Rigidbody>() == null)
            {
                gameObject.AddComponent<Rigidbody>();
            }
        }
    }
}
