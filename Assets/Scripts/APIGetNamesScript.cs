using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json.Linq;
using UnityEngine.UIElements;

public class APIGetNamesScript : MonoBehaviour
{
    public static string[,] names;
    void Start()
    {
        // A correct website page.
        StartCoroutine(GetRequest("https://catbingochild.azurewebsites.net/api/CatBingoState"));
        Debug.Log("Get name Method completed");

    }

    public void getnames()
    {
        // A correct website page.
        StartCoroutine(GetRequest("https://catbingochild.azurewebsites.net/api/CatBingoState"));
        Debug.Log("Get name Method completed");
    }

    public IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    //Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text.GetType());

                    var gamestate = JArray.Parse(webRequest.downloadHandler.text);
                    //gameState state = JsonUtility.FromJson<gameState>(webRequest.downloadHandler.text.ToString()); ;
                    names = new string[gamestate.Count,2];
                    
                    int i = 0;
                    foreach (JObject root in gamestate)
                    {
                        //string name = JsonUtility.FromJson<Collection<PlayerNames>>(JObject.Parse(root)["name"]);
                        names[i, 0] = root["id"].ToString();
                        names[i, 1] = root["name"].ToString();
                        //Debug.Log(root["id"] + " " + root["name"]);
                        i = i + 1;

                        
                    }


                    //Debug.Log(state.name + " " + state.watermelon);
                    //gameState gamestatestruct = JsonUtility.FromJson<gameState>(webRequest.downloadHandler.text);
                    //Debug.Log(gamestatestruct.name + "" + gamestatestruct.id.ToString());
                    break;
            }
        }
    }

}

public class PlayerNames
{
    public int id;
    public string name;
}
