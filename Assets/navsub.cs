using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navsub : MonoBehaviour
{
    public void move(int S)
    {
        SceneManager.LoadScene(S);
    }
}
