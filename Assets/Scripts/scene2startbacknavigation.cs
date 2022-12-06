using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2startbacknavigation : MonoBehaviour
{
    public void start(int sceneID1)
    {
        SceneManager.LoadScene(sceneID1);
    }
    public void back(int sceneID2)
    {
        SceneManager.LoadScene(sceneID2);
    }
}
