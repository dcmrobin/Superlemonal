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
}