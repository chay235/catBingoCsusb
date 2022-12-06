using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

public class APIGetScript : MonoBehaviour
{
    //public string uri = "https://catbingochild.azurewebsites.net/api/CatBingoState/";
    // Start is called before the first frame update
    //public void getPlayerState(int id)
    public void Start()
    {

        string uri = "https://catbingochild.azurewebsites.net/api/CatBingoState/"+Game_state.id;
        Debug.Log(uri);
        // A correct website page.
        StartCoroutine(GetRequest(uri));

        // A non-existing page.
        //StartCoroutine(GetRequest("https://error.html"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            Debug.Log("in get method br");
            yield return webRequest.SendWebRequest();
            Debug.Log("in get method ar");

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

                    
                    //var gamestate= JArray.Parse(webRequest.downloadHandler.text);
                    gameState state = JsonUtility.FromJson<gameState>(webRequest.downloadHandler.text.ToString()); ;
                    //foreach (JObject root in gamestate)
                    //{
                    //     state
                    //    //Debug.Log(state.name);
                    //}
                    JObject json = JObject.Parse(webRequest.downloadHandler.text);
                    Debug.Log("Scores from state brough from get method" +json["id"]+ json["name"] + " " + json["easyScore"] +"watermelons"+ json["watermelon"]);

                    Game_state.id = state.id;
                    Game_state.name=state.name;
                    Game_state.Qcategory1 = state.qcategory1;
                    Game_state.Qcategory2 = state.qcategory2;
                    Game_state.Qcategory3= state.qcategory3;
                    Game_state.Qcategory4 = state.qcategory4;
                    Game_state.Qcategory5 = state.qcategory5;
                    Game_state.Qcategory6 = state.qcategory6;
                    Game_state.Qcategory7 = state.qcategory7;
                    Game_state.Qcategory8 = state.qcategory8;
                    Game_state.Qcategory9 = state.qcategory9;
                    Game_state.Qcategory10 = state.qcategory10;
                    Game_state.Qcategory11 = state.qcategory11;
                    Game_state.Qcategory12 = state.qcategory12;
                    Game_state.Qcategory13 = state.qcategory13;
                    Game_state.Qcategory14 = state.qcategory14;
                    Game_state.Qcategory15 = state.qcategory15;
                    Game_state.Qcategory16 = state.qcategory16;
                    Game_state.Qcategory17 = state.qcategory17;
                    Game_state.Acategory1 = state.acategory1;
                    Game_state.Acategory2 = state.acategory2;
                    Game_state.Acategory3 = state.acategory3;
                    Game_state.Acategory4 = state.acategory4;
                    Game_state.Acategory5 = state.acategory5;
                    Game_state.Acategory6 = state.acategory6;
                    Game_state.Acategory7 = state.acategory7;
                    Game_state.Acategory8 = state.acategory8;
                    Game_state.Acategory9 = state.acategory9;
                    Game_state.Acategory10 = state.acategory10;
                    Game_state.Acategory11 = state.acategory11;
                    Game_state.Acategory12 = state.acategory12;
                    Game_state.Acategory13 = state.acategory13;
                    Game_state.Acategory14 = state.acategory14;
                    Game_state.Acategory15 = state.acategory15;
                    Game_state.Acategory16 = state.acategory16;
                    Game_state.Acategory17 = state.acategory17;
                    Game_state.EasyScore = state.easyScore;
                    Game_state.MediumScore = state.mediumScore;
                    Game_state.HardScore = state.hardScore;
                    Game_state.guava = state.guava;
                    Game_state.watermelon = state.watermelon;
                    Game_state.orange = state.orange;
                    Game_state.apple = state.apple;

                    Debug.Log(state.name + " " + state.watermelon);
                    Debug.Log("Scores from APIGet Script for " + Game_state.name + " " + Game_state.EasyScore);

                    //gameState gamestatestruct = JsonUtility.FromJson<gameState>(webRequest.downloadHandler.text);
                    //Debug.Log(gamestatestruct.name + "" + gamestatestruct.id.ToString());
                    break;
            }
        }
    }
    
}
public class gameState
{
    public int id;
    public string name;
    public int qcategory1;
    public int qcategory2;
    public int qcategory3;
    public int qcategory4;
    public int qcategory5;
    public int qcategory6;
    public int qcategory7;
    public int qcategory8;
    public int qcategory9;
    public int qcategory10;
    public int qcategory11;
    public int qcategory12;
    public int qcategory13;
    public int qcategory14;
    public int qcategory15;
    public int qcategory16;
    public int qcategory17;
    public int acategory1;
    public int acategory2;
    public int acategory3;
    public int acategory4;
    public int acategory5;
    public int acategory6;
    public int acategory7;
    public int acategory8;
    public int acategory9;
    public int acategory10;
    public int acategory11;
    public int acategory12;
    public int acategory13;
    public int acategory14;
    public int acategory15;
    public int acategory16;
    public int acategory17;
    public int easyScore;
    public int mediumScore;
    public int hardScore;
    public int guava;
    public int watermelon;
    public int orange;
    public int apple;
}


