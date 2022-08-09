using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeHolder : MonoBehaviour
{
    public void vend(Ray ray, RaycastHit hit, bool isRayTouchingSomething, float rayMaxRange, LayerMask layerMask, float objectmass)
    {
        if ((Input.GetMouseButtonDown(0)) && isRayTouchingSomething && Physics.Raycast(ray, out hit, rayMaxRange, layerMask))
        {
            if (hit.transform.tag == "vendingButton")
            {
                if (hit.transform.gameObject.GetComponent<vendingButton>().can == vendingButton.canColor.Red)
                {
                    if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/vendingButton");
                        GameObject canObj = Instantiate(hit.transform.gameObject.GetComponent<vendingButton>().redCan, hit.transform.parent.Find("canSpawnPoint").gameObject.transform.position, Quaternion.identity);
                        canObj.AddComponent<Rigidbody>();
                        canObj.GetComponent<Rigidbody>().mass = objectmass;
                        canObj.transform.eulerAngles = new Vector3(
                            canObj.transform.eulerAngles.x + 90,
                            canObj.transform.eulerAngles.y,
                            canObj.transform.eulerAngles.z
                        );
                        hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed = true;
                        hit.transform.gameObject.GetComponentInChildren<MeshRenderer>().material = hit.transform.gameObject.GetComponent<vendingButton>().redMaterial;
                    }
                }

                if (hit.transform.gameObject.GetComponent<vendingButton>().can == vendingButton.canColor.Green)
                {
                    if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/vendingButton");
                        GameObject canObj = Instantiate(hit.transform.gameObject.GetComponent<vendingButton>().greenCan, hit.transform.parent.Find("canSpawnPoint").gameObject.transform.position, Quaternion.identity);
                        canObj.AddComponent<Rigidbody>();
                        canObj.GetComponent<Rigidbody>().mass = objectmass;
                        canObj.transform.eulerAngles = new Vector3(
                            canObj.transform.eulerAngles.x + 90,
                            canObj.transform.eulerAngles.y,
                            canObj.transform.eulerAngles.z
                        );
                        hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed = true;
                        hit.transform.gameObject.GetComponentInChildren<MeshRenderer>().material = hit.transform.gameObject.GetComponent<vendingButton>().greenMaterial;
                    }
                }

                if (hit.transform.gameObject.GetComponent<vendingButton>().can == vendingButton.canColor.Blue)
                {
                    if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/vendingButton");
                        GameObject canObj = Instantiate(hit.transform.gameObject.GetComponent<vendingButton>().blueCan, hit.transform.parent.Find("canSpawnPoint").gameObject.transform.position, Quaternion.identity);
                        canObj.AddComponent<Rigidbody>();
                        canObj.GetComponent<Rigidbody>().mass = objectmass;
                        canObj.transform.eulerAngles = new Vector3(
                            canObj.transform.eulerAngles.x + 90,
                            canObj.transform.eulerAngles.y,
                            canObj.transform.eulerAngles.z
                        );
                        hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed = true;
                        hit.transform.gameObject.GetComponentInChildren<MeshRenderer>().material = hit.transform.gameObject.GetComponent<vendingButton>().blueMaterial;
                    }
                }

                if (hit.transform.gameObject.GetComponent<vendingButton>().can == vendingButton.canColor.Purple)
                {
                    if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/vendingButton");
                        GameObject canObj = Instantiate(hit.transform.gameObject.GetComponent<vendingButton>().purpleCan, hit.transform.parent.Find("canSpawnPoint").gameObject.transform.position, Quaternion.identity);
                        canObj.AddComponent<Rigidbody>();
                        canObj.GetComponent<Rigidbody>().mass = objectmass;
                        canObj.transform.eulerAngles = new Vector3(
                            canObj.transform.eulerAngles.x + 90,
                            canObj.transform.eulerAngles.y,
                            canObj.transform.eulerAngles.z
                        );
                        hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed = true;
                        hit.transform.gameObject.GetComponentInChildren<MeshRenderer>().material = hit.transform.gameObject.GetComponent<vendingButton>().purpleMaterial;
                    }
                }

                if (hit.transform.gameObject.GetComponent<vendingButton>().can == vendingButton.canColor.LightBlue)
                {
                    if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/vendingButton");
                        GameObject canObj = Instantiate(hit.transform.gameObject.GetComponent<vendingButton>().lightblueCan, hit.transform.parent.Find("canSpawnPoint").gameObject.transform.position, Quaternion.identity);
                        canObj.AddComponent<Rigidbody>();
                        canObj.GetComponent<Rigidbody>().mass = objectmass;
                        canObj.transform.eulerAngles = new Vector3(
                            canObj.transform.eulerAngles.x + 90,
                            canObj.transform.eulerAngles.y,
                            canObj.transform.eulerAngles.z
                        );
                        hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed = true;
                        hit.transform.gameObject.GetComponentInChildren<MeshRenderer>().material = hit.transform.gameObject.GetComponent<vendingButton>().lightblueMaterial;
                    }
                }

                if (hit.transform.gameObject.GetComponent<vendingButton>().can == vendingButton.canColor.Yellow)
                {
                    if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/vendingButton");
                        GameObject canObj = Instantiate(hit.transform.gameObject.GetComponent<vendingButton>().yellowCan, hit.transform.parent.Find("canSpawnPoint").gameObject.transform.position, Quaternion.identity);
                        canObj.AddComponent<Rigidbody>();
                        canObj.GetComponent<Rigidbody>().mass = objectmass;
                        canObj.transform.eulerAngles = new Vector3(
                            canObj.transform.eulerAngles.x + 90,
                            canObj.transform.eulerAngles.y,
                            canObj.transform.eulerAngles.z
                        );
                        hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed = true;
                        hit.transform.gameObject.GetComponentInChildren<MeshRenderer>().material = hit.transform.gameObject.GetComponent<vendingButton>().yellowMaterial;
                    }
                }

                if (hit.transform.gameObject.GetComponent<vendingButton>().can == vendingButton.canColor.Orange)
                {
                    if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                    {
                        FMODUnity.RuntimeManager.PlayOneShot("event:/vendingButton");
                        GameObject canObj = Instantiate(hit.transform.gameObject.GetComponent<vendingButton>().orangeCan, hit.transform.parent.Find("canSpawnPoint").gameObject.transform.position, Quaternion.identity);
                        canObj.AddComponent<Rigidbody>();
                        canObj.GetComponent<Rigidbody>().mass = objectmass;
                        canObj.transform.eulerAngles = new Vector3(
                            canObj.transform.eulerAngles.x + 90,
                            canObj.transform.eulerAngles.y,
                            canObj.transform.eulerAngles.z
                        );
                        hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed = true;
                        hit.transform.gameObject.GetComponentInChildren<MeshRenderer>().material = hit.transform.gameObject.GetComponent<vendingButton>().orangeMaterial;
                    }
                }
            }
        }
    }
    public void drawSig(Ray ray, RaycastHit hit, LayerMask layerMask, bool signatureAble, GameObject pointer, Sprite handaboutgrabby, Sprite handnograbby, bool isRayTouchingSomething, GameObject gameobjecttodeactivate, GameObject signatureobject)
    {
        if (Physics.Raycast(ray, out hit, 2, layerMask))
        {
            if (hit.transform.tag == "agreementpaper")
            {
                if (signatureAble)
                {
                    pointer.GetComponent<SpriteRenderer>().sprite = handaboutgrabby;
                } else
                {
                    pointer.GetComponent<SpriteRenderer>().sprite = handnograbby;
                }
                if ((Input.GetMouseButtonDown(0)) && isRayTouchingSomething)
                {
                    if (hit.transform.tag == "agreementpaper")
                    {
                        if (signatureAble)
                        {
                            gameobjecttodeactivate.SetActive(false);
                            signatureobject.SetActive(true);
                            FMODUnity.RuntimeManager.PlayOneShot("event:/sig");
                            signatureAble = false;
                        }
                    }
                }
            }
        }
    }
    public void changeHandSprite(Ray ray, RaycastHit hit, float rayMaxRange, LayerMask layerMask, GameObject pointer, Sprite handaboutgrabby, Sprite handnograbby, GameObject takenObject, Sprite handgrabby, Transform targetForTakenObjects)
    {
        if (Physics.Raycast(ray, out hit, rayMaxRange, layerMask))
        {
            if (hit.transform.tag == "Getable" || hit.transform.tag == "PictureOnTheWall")
            {
                //pointer.GetComponent<MeshRenderer>().material = blueToon;
                pointer.GetComponent<SpriteRenderer>().sprite = handaboutgrabby;
            }
            else
            {
                //pointer.GetComponent<MeshRenderer>().material = yellowToon;
                pointer.GetComponent<SpriteRenderer>().sprite = handnograbby;
            }
            if (hit.transform.tag == "vendingButton")
            {
                if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                {
                    pointer.GetComponent<SpriteRenderer>().sprite = handaboutgrabby;
                }
            }
            else if(hit.transform.tag == "vendingButton")
            {
                if (hit.transform.gameObject.GetComponent<vendingButton>().hasBeenPressed == false)
                {
                    //pointer.GetComponent<MeshRenderer>().material = yellowToon;
                    pointer.GetComponent<SpriteRenderer>().sprite = handnograbby;
                }
            }
        }
        if (takenObject != null)
        {
            pointer.GetComponent<SpriteRenderer>().sprite = handgrabby;
        }
        else
        {
            targetForTakenObjects.position = hit.point;
        }
    }
}
