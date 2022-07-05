using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// https://medium.com/c-sharp-progarmming/make-smooth-scene-transitions-in-unity-c-6b7c97e4c7e0
public class SceneLoader : MonoBehaviour
{
    public Animator crossFade;

    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        //     StartCoroutine(LoadNextScene());
    }

    public IEnumerator LoadNextScene()
    {
        crossFade.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        Scene scene = SceneManager.GetActiveScene();
        int nextLevelBuildIndex = 1 - scene.buildIndex;
        SceneManager.LoadScene(nextLevelBuildIndex);
        SceneManager.LoadScene("SharedStuff", LoadSceneMode.Additive);
    }
}