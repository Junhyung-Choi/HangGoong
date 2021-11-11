using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum ESceneList
{
    Main,
    Flower,
    Wood,
    Ceramic,
    Baking
}

public class ChangeScene : MonoBehaviour
{
    public ESceneList scene;
    public void SceneChange()
    {
        switch(scene)
        {
            case ESceneList.Main:
                SceneManager.LoadScene("Main");
                break;
            case ESceneList.Flower:
                SceneManager.LoadScene("Flower");
                break;
            case ESceneList.Wood:
                SceneManager.LoadScene("Wood");
                break;
            case ESceneList.Ceramic:
                SceneManager.LoadScene("Ceramic");
                break;
            case ESceneList.Baking:
                SceneManager.LoadScene("Baking");
                break;
        }
    }
}
