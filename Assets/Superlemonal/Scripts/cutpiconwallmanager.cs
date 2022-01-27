using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cutpiconwallmanager : MonoBehaviour
{

    //public bool thang = false;
    private GameObject pointer;
    public GameObject player;
    public GameObject pictureOnTheWall;
    public GameObject objectToSpawn;
    public float targetX = 0;
    public float targetY = 0;
    public float targetZ = 0;

    private bool isInRange(int distance){

        var xOffset = Math.Abs(player.transform.position.x - targetX);
        var yOffset = Math.Abs(player.transform.position.y - targetY);
        var zOffset = Math.Abs(player.transform.position.z - targetZ);

        return (xOffset <= distance && yOffset <= distance && zOffset <= distance );
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange(1))
        {
            //Debug.Log("oh yes i'm in range");
        }
    }

    void OnMouseDown()
    {
        if(isInRange(1))
        {
            //Debug.Log("i clicked");
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            Destroy(pictureOnTheWall);
        }
    }
}
