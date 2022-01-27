using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Animator buttonAnimationController;
    public Animator doorAnimationController;
    public GameObject sign;
    public Material greenMaterial;

    //[SerializeField] private string buttonPress = "ButtonPress";

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Getable") && col.gameObject.GetComponent<Rigidbody>().isKinematic == false)
        {
            //Debug.Log("ouch");
            buttonAnimationController.SetBool("bool", true);
            doorAnimationController.SetBool("doorBool", true);
            
            buttonAnimationController.SetBool("bugfixerbool", false);
            doorAnimationController.SetBool("bugfixerbool", false);
        }
        if (col.gameObject.CompareTag("Player"))
        {
            //Debug.Log("ouch");
            sign.GetComponent<MeshRenderer>().material = greenMaterial;//continue
            buttonAnimationController.SetBool("bool", true);
            doorAnimationController.SetBool("doorBool", true);
            
            buttonAnimationController.SetBool("bugfixerbool", false);
            doorAnimationController.SetBool("bugfixerbool", false);
        }
    }

    void OnTriggerExit(Collider col)
    {
        buttonAnimationController.SetBool("bool", false);
        doorAnimationController.SetBool("doorBool", false);

        buttonAnimationController.SetBool("bugfixerbool", true);
        doorAnimationController.SetBool("bugfixerbool", true);
    }
}
