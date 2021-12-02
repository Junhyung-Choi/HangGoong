using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
    public UnityEvent OnLoadBegin = new UnityEvent();
    public UnityEvent OnLoadEnd = new UnityEvent();
    public UnityEvent screenFader = null;
    private void Awake()
    {
      SceneManager.sceneLoaded += SetActiveScene;
    }

    private void OnDestroy()
    {
      SceneManager.sceneLoaded -= SetActiveScene;
    }

    public void LoadNewScene(string sceneName)
    {

    }

    private IEnumerator LoadScene(string sceneName)
    {
		yield return null;
    }

    private IEnumerator UnloadCurrent()
    {
		yield return null;
    }

    private IEnumerator LoadNew(string sceneName)
    {
		yield return null;
    }

    private void SetActiveScene(Scene scene, LoadSceneMode mode)
    {

    }
}

