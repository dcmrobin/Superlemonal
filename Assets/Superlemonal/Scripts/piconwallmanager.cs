using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piconwallmanager : MonoBehaviour
{
    //public bool thang = false;
    public GameObject pictureOnTheWall;
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(pictureOnTheWall);
        //thang = true;
        //Debug.Log("ogh");
        //if(thang == true)
        //{
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            //thang = false;
        //}
        
    }
}
