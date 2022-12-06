using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation_bingo : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("Scores from navigation bingo for "+Game_state.name+" "+Game_state.EasyScore);   
    }


    // Start is called before the first frame update
    public void report_card_nav(int sceneID1)
    {
        SceneManager.LoadScene(sceneID1);
    }
    public void feed_nav(int sceneID1)
    {
        SceneManager.LoadScene(sceneID1);
        
    }
    public void home_nav(int sceneID1)
    {
        SceneManager.LoadScene(sceneID1);
    }

    public void exit_nav(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
