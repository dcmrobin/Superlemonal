using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    Material[] mats;
    public Animator buttonAnimationController;
    public Animator doorAnimationController;
    public GameObject sign;
    public Material greenLight;
    public Material redLight;
    public Material originalGreen;
    public Material originalRed;

    //[SerializeField] private string buttonPress = "ButtonPress";

    void Start()
    {
        mats = sign.GetComponent<MeshRenderer>().materials;
        mats[1] = redLight;
        sign.GetComponent<MeshRenderer>().materials = mats;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Getable") && col.gameObject.GetComponent<Rigidbody>().isKinematic == false)
        {
            //Debug.Log("ouch");
            buttonAnimationController.SetBool("bool", true);
            doorAnimationController.SetBool("doorBool", true);
            buttonAnimationController.SetBool("bugfixerbool", false);
            doorAnimationController.SetBool("bugfixerbool", false);
            mats[1] = originalRed;
            sign.GetComponent<MeshRenderer>().materials = mats;
            mats[2] = greenLight;
            sign.GetComponent<MeshRenderer>().materials = mats;
        }
        if (col.gameObject.CompareTag("Player"))
        {
            buttonAnimationController.SetBool("bool", true);
            doorAnimationController.SetBool("doorBool", true);
            buttonAnimationController.SetBool("bugfixerbool", false);
            doorAnimationController.SetBool("bugfixerbool", false);
            mats[1] = originalRed;
            sign.GetComponent<MeshRenderer>().materials = mats;
            mats[2] = greenLight;
            sign.GetComponent<MeshRenderer>().materials = mats;
        }
    }

    void OnTriggerExit(Collider col)
    {
        buttonAnimationController.SetBool("bool", false);
        doorAnimationController.SetBool("doorBool", false);
        buttonAnimationController.SetBool("bugfixerbool", true);
        doorAnimationController.SetBool("bugfixerbool", true);
        mats[1] = redLight;
        sign.GetComponent<MeshRenderer>().materials = mats;
        mats[2] = originalGreen;
        sign.GetComponent<MeshRenderer>().materials = mats;
    }
}
