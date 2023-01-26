using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vendingButton : MonoBehaviour
{
    public enum canColor{Red, Green, Blue, Purple, LightBlue, Yellow, Orange};
    public canColor can;
    public GameObject redCan;
    public GameObject greenCan;
    public GameObject blueCan;
    public GameObject purpleCan;
    public GameObject lightblueCan;
    public GameObject yellowCan;
    public GameObject orangeCan;
    public Material redMaterial;
    public Material greenMaterial;
    public Material blueMaterial;
    public Material purpleMaterial;
    public Material lightblueMaterial;
    public Material yellowMaterial;
    public Material orangeMaterial;
    public bool hasBeenPressed = false;
    public int randNum = 0;

    void Start()
    {
        randNum = UnityEngine.Random.Range(0, 2);
        if (randNum == 0)
        {
            hasBeenPressed = false;
        }
        else if (randNum == 1)
        {
            hasBeenPressed = true;
        }
        if (can == canColor.Red && hasBeenPressed)
        {
            gameObject.GetComponent<Renderer>().material = redMaterial;
        }
        else if (can == canColor.Blue && hasBeenPressed)
        {
            gameObject.GetComponent<Renderer>().material = blueMaterial;
        }
        else if (can == canColor.Green && hasBeenPressed)
        {
            gameObject.GetComponent<Renderer>().material = greenMaterial;
        }
        else if (can == canColor.Purple && hasBeenPressed)
        {
            gameObject.GetComponent<Renderer>().material = purpleMaterial;
        }
        else if (can == canColor.LightBlue && hasBeenPressed)
        {
            gameObject.GetComponent<Renderer>().material = lightblueMaterial;
        }
        else if (can == canColor.Yellow && hasBeenPressed)
        {
            gameObject.GetComponent<Renderer>().material = yellowMaterial;
        }
        else if (can == canColor.Orange && hasBeenPressed)
        {
            gameObject.GetComponent<Renderer>().material = orangeMaterial;
        }
    }
}