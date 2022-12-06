using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_name_entered : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void create()
    {
        APIPostScript script = GameObject.FindObjectOfType(typeof(APIPostScript)) as APIPostScript;
        script.createNewProfile();
        //APIGetNamesScript script2 = GameObject.FindObjectOfType(typeof(APIGetNamesScript)) as APIGetNamesScript;
        //script2.getnames();
        //int curr_id = System.Int32.Parse(APIGetNamesScript.names[(APIGetNamesScript.names.Length / 2) - 1, 0]);
        //PlayerScrollViewController.id_of_selected_player = curr_id;
        //System.Threading.Thread.Sleep(3000);
        SceneManager.LoadScene(0);
    }



}
