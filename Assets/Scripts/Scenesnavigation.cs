using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenesnavigation : MonoBehaviour
{
    public void Playgame(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void quit(int sceneI)
    {
        SceneManager.LoadScene(sceneI);
    }
}
