using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrollViewController : MonoBehaviour
{
    //[SerializeField] int no_of_players;
    [SerializeField] GameObject player_button_prefab;
    [SerializeField] Transform playerBtnParent;
    public static int id_of_selected_player;

    // Start is called before the first frame update
    void Start()
    {
        PlayerButtonLoad();
    }

    // Update is called once per frame
    public void PlayerButtonLoad()
    {
        //Debug.Log(APIGetNamesScript.names.GetLength(0)+" "+ APIGetNamesScript.names.GetLength(1));
        for(int i=0;i< APIGetNamesScript.names.Length/2; i++)
        {
            //Debug.Log(i);
            //Debug.Log(APIGetNamesScript.names[i, 1]);
            GameObject player = Instantiate(player_button_prefab, playerBtnParent);
            player.GetComponent<PlayerButtonItem>().playerindex = i;
            player.GetComponent<PlayerButtonItem>().playerScrollViewController = this;
            //player.GetComponent<PlayerButtonItem>().PlayerNameText.text = APIGetNamesScript.names[i, 1];

        }
        
    }
}
