using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class APIPostScript : MonoBehaviour
{
    public TMP_Text new_player_name;
    public int sceneid=2;
    //void Start()
    //{
    //    StartCoroutine(Upload());
    //}

    public void createNewProfile()
    {
        
        StartCoroutine(Upload(new_player_name.text));
        //SceneManager.LoadScene(sceneid);
    }


    IEnumerator Upload(string name)
    {
        Debug.Log("name in upload method" + name);

        gameState state = new gameState();
        state.name =name.Substring(0,name.Length-1);
        state.qcategory1 = 0;
        state.qcategory2 = 0;
        state.qcategory3 = 0;
        state.qcategory4 = 0;
        state.qcategory5 = 0;
        state.qcategory6 =0;
        state.qcategory7 = 0;
        state.qcategory8 = 0;
        state.qcategory9 = 0;
        state.qcategory10 = 0;
        state.qcategory11 = 0;
        state.qcategory12 = 0;
        state.qcategory13 = 0;
        state.qcategory14 = 0;
        state.qcategory15 = 0;
        state.qcategory16 = 0;
        state.qcategory17 = 0;
        state.acategory1 = 0;
        state.acategory2 = 0;
        state.acategory3 =0;
        state.acategory4 =0;
        state.acategory5 = 0;
        state.acategory6 = 0;
        state.acategory7 = 0;
        state.acategory8 = 0;
        state.acategory9 = 0;
        state.acategory10 = 0;
        state.acategory11 = 0;
        state.acategory12 = 0;
        state.acategory13 = 0;
        state.acategory14 = 0;
        state.acategory15 = 0;
        state.acategory16 = 0;
        state.acategory17 = 0;
        state.easyScore = 0;
        state.mediumScore = 0;
        state.hardScore = 0;
        state.guava = 0;
        state.watermelon = 0;
        state.orange = 0;
        state.apple = 0;

        byte[] myData = new System.Text.UTF8Encoding().GetBytes(JsonUtility.ToJson(state));

        //UnityWebRequest www = UnityWebRequest.Post("https://catbingochild.azurewebsites.net/api/CatBingoState", form);
        UnityWebRequest www = new UnityWebRequest("https://catbingochild.azurewebsites.net/api/CatBingoState", "POST");
        www.uploadHandler = (UploadHandler)new UploadHandlerRaw(myData);
        www.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("post error: "+www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
        www.uploadHandler.Dispose();
        www.downloadHandler.Dispose();
        www.Dispose();
        
    }
}
