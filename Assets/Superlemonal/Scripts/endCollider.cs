using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endCollider : MonoBehaviour
{
    public int sceneNum = 0;

    private void OnTriggerEnter(Collider other) {
        if (other.transform.CompareTag("Player"))
        {
            StartCoroutine(LoadAsyncScene());
        }
    }

    IEnumerator LoadAsyncScene()
    {
        yield return SceneManager.LoadSceneAsync(sceneNum, LoadSceneMode.Single);
    }
}
