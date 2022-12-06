using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerButtonItem : MonoBehaviour
{
    [HideInInspector] public int playerindex;
    [HideInInspector] public int player_id;
    [HideInInspector] public PlayerScrollViewController playerScrollViewController;

    [SerializeField] public TMP_Text PlayerNameText;
    

    //APIGetScript apiget;
    public int sceneid;
    public void Start()
    {
        PlayerNameText.text = APIGetNamesScript.names[playerindex,1];
        player_id = Int32.Parse(APIGetNamesScript.names[playerindex, 0]);
        //apiget = FindObjectOfType<APIGetScript>();

        //Debug.Log(PlayerNameText.text);
    }
    public void onPlayerButtonClick()
    {
        PlayerScrollViewController.id_of_selected_player = player_id;
        Game_state.id = player_id;
        //apiget.getPlayerState(player_id);
        SceneManager.LoadScene(sceneid);
        
    }

    
}
