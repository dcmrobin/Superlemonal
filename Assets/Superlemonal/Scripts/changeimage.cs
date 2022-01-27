using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeimage : MonoBehaviour
{   public Image m_Image;
    public Sprite handnograbby;
    public Sprite handabouttograbby;
    public Sprite handgrabby;

    void Start()
    {
        //Fetch the Image from the GameObject
        //m_Image = GetComponent<Image>();
    }

    void Update()
    {
        //Press space to change the Sprite of the Image
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    m_Image.sprite = m_Sprite;
        //}
    }

    public void OnMouseOver()
    {
        //Debug.Log("woweee");
        m_Image.sprite = handabouttograbby;
    }

    public void OnMouseExit()
    {
        //Debug.Log("woweeenooo");
        m_Image.sprite = handnograbby;
    }

    public void OnMouseDown()
    {
        //Debug.Log("woweeenooo");
        m_Image.sprite = handgrabby;
    }
}
