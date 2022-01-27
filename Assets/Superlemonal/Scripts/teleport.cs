using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    CharacterController cc;
    public GameObject player;
    public GameObject destination;
    //public Transform[] thang;      Custom List, displaying data your way
    // Start is called before the first frame update
    void Start()
    {
        //
        cc = player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider thing)
    {
        if(thing.tag == "Player")
        {
            //teleport him
            cc.enabled = false;
            player.transform.position = destination.transform.position;
            //player.transform.scale = destination.transform.scale;
            cc.enabled = true;
            //Debug.Log("wah");
        }
    }

}
