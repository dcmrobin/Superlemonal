using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noobject : MonoBehaviour
{
    public PerspectiveManager perspectiveManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter()
    {
        perspectiveManager.releaseObject();
    }
}
