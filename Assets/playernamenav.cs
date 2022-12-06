using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playernamenav : MonoBehaviour
{
    public void move(int S)
    {
        SceneManager.LoadScene(S);
    }
}
