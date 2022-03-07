using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noobject : MonoBehaviour
{
    PerspectiveManager perspectiveManager;
    public Animator animator;
    //bool toneAble = false;
    // Start is called before the first frame update
    void Start()
    {
        perspectiveManager = GameObject.Find("PerpectiveManager").GetComponent<PerspectiveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(perspectiveManager.isGrabbing)
        {
            gameObject.GetComponent<Collider>().isTrigger = false;
            animator.SetBool("planeBool", true);
            animator.SetBool("bugfixerbool", false);
        } else if(!perspectiveManager.isGrabbing)
        {
            gameObject.GetComponent<Collider>().isTrigger = true;
            animator.SetBool("planeBool", false);
            animator.SetBool("bugfixerbool", true);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (!perspectiveManager.isGrabbing)
            {
                FMODUnity.RuntimeManager.PlayOneShot("event:/wobble");
            }
        }
    }
}
