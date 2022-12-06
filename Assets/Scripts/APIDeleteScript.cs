using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class APIDeleteScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Delete_Student()
    {
        string delete_api = "https://catbingochild.azurewebsites.net/api/CatBingoState/"+Game_state.id;
        WebRequest myRequest = WebRequest.Create(delete_api);
        myRequest.Method = "DELETE";
        WebResponse myResponse = myRequest.GetResponse();
        Debug.Log(myResponse);
        SceneManager.LoadScene(0);
    }


}
