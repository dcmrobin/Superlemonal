using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using FMODUnity;

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
    public List<GameObject> gameObjectsInCollision;
    //public AudioSource buttonSound;
    //public AudioSource doorSound;

    //[SerializeField] private string buttonPress = "ButtonPress";

    void Start()
    {
        mats = sign.GetComponent<MeshRenderer>().materials;
        mats[1] = redLight;
        sign.GetComponent<MeshRenderer>().materials = mats;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Collider>().isTrigger == false)
        {
            if (col.gameObject.CompareTag("Getable") && col.gameObject.GetComponent<Rigidbody>().isKinematic == false || col.gameObject.CompareTag("Player"))
            {
                if (gameObjectsInCollision.Count == 0)
                {
                    buttonAnimationController.SetBool("bool", true);
                    doorAnimationController.SetBool("doorBool", true);
                    buttonAnimationController.SetBool("bugfixerbool", false);
                    doorAnimationController.SetBool("bugfixerbool", false);
                    //buttonSound.Play();
                    //doorSound.Play();
        
                    FMODUnity.RuntimeManager.PlayOneShot("event:/button");
                    FMODUnity.RuntimeManager.PlayOneShot("event:/door");
        
                    mats[1] = originalRed;
                    sign.GetComponent<MeshRenderer>().materials = mats;
                    mats[2] = greenLight;
                    sign.GetComponent<MeshRenderer>().materials = mats;
                }
                gameObjectsInCollision.Add(col.gameObject);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        /*if (col.gameObject.CompareTag("Player"))
        {
            gameObjectsInCollision.RemoveAt(gameObjectsInCollision.Count - 1);
        }
        if (col.gameObject.CompareTag("Getable") && gameObjectsInCollision.Count > 1)
        {
            gameObjectsInCollision.RemoveAt(gameObjectsInCollision.Count - 1);
        }*/
        gameObjectsInCollision.RemoveAt(gameObjectsInCollision.Count - 1);
        if (gameObjectsInCollision.Count == 0)
        {
            buttonAnimationController.SetBool("bool", false);
            doorAnimationController.SetBool("doorBool", false);
            buttonAnimationController.SetBool("bugfixerbool", true);
            doorAnimationController.SetBool("bugfixerbool", true);
            
            FMODUnity.RuntimeManager.PlayOneShot("event:/button");
            FMODUnity.RuntimeManager.PlayOneShot("event:/door");
        
            mats[1] = redLight;
            sign.GetComponent<MeshRenderer>().materials = mats;
            mats[2] = originalGreen;
            sign.GetComponent<MeshRenderer>().materials = mats;
        }
    }
}
