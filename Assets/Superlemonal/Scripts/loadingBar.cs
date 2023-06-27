using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingBar : MonoBehaviour
{
    public Slider bar;
    public int sceneNumToLoad;
    bool loadScene;
    bool stopLoading;

    // Update is called once per frame
    void Update()
    {
        bar.value += 1f;
        if (bar.value >= 20 && !stopLoading)
        {
            loadScene = true;
            stopLoading = true;
        }
        else if (bar.value >= 100)
        {
            SceneManager.UnloadSceneAsync(0);
        }
        if (loadScene)
        {
            StartCoroutine(LoadYourAsyncScene());
            loadScene = false;
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        /*AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneNumToLoad, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }*/
        yield return SceneManager.LoadSceneAsync(sceneNumToLoad, LoadSceneMode.Additive);
    }
}
