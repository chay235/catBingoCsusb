using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor.PackageManager.Requests;

public class APIPutScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Started");
        exec_update();
    }

    public void exec_update()
    {
        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        gameState state=new gameState();
        state.id = Game_state.id;
        state.name = Game_state.name;
        state.qcategory1 = Game_state.Qcategory1;
        state.qcategory2 = Game_state.Qcategory2;
        state.qcategory3 = Game_state.Qcategory3;
        state.qcategory4 = Game_state.Qcategory4;
        state.qcategory5 = Game_state.Qcategory5;
        state.qcategory6 = Game_state.Qcategory6;
        state.qcategory7 = Game_state.Qcategory7;
        state.qcategory8 = Game_state.Qcategory8;
        state.qcategory9 = Game_state.Qcategory9;
        state.qcategory10 = Game_state.Qcategory10;
        state.qcategory11 = Game_state.Qcategory11;
        state.qcategory12 = Game_state.Qcategory12;
        state.qcategory13 = Game_state.Qcategory13;
        state.qcategory14 = Game_state.Qcategory14;
        state.qcategory15 = Game_state.Qcategory15;
        state.qcategory16 = Game_state.Qcategory16;
        state.qcategory17 = Game_state.Qcategory17;
        state.acategory1 = Game_state.Acategory1;
        state.acategory2 = Game_state.Acategory2;
        state.acategory3 = Game_state.Acategory3;
        state.acategory4 = Game_state.Acategory4;
        state.acategory5 = Game_state.Acategory5;
        state.acategory6 = Game_state.Acategory6;
        state.acategory7 = Game_state.Acategory7;
        state.acategory8 = Game_state.Acategory8;
        state.acategory9 = Game_state.Acategory9;
        state.acategory10 = Game_state.Acategory10;
        state.acategory11 = Game_state.Acategory11;
        state.acategory12 = Game_state.Acategory12;
        state.acategory13 = Game_state.Acategory13;
        state.acategory14 = Game_state.Acategory14;
        state.acategory15 = Game_state.Acategory15;
        state.acategory16 = Game_state.Acategory16;
        state.acategory17 = Game_state.Acategory17;
        state.easyScore = Game_state.EasyScore;
        state.mediumScore = Game_state.MediumScore;
        state.hardScore = Game_state.HardScore;
        state.guava = Game_state.guava;
        state.watermelon = Game_state.watermelon;
        state.orange = Game_state.orange;
        state.apple = Game_state.apple;
        Debug.Log("states upload");
        byte[] myData = new System.Text.UTF8Encoding().GetBytes(JsonUtility.ToJson(state));

        UnityWebRequest www = UnityWebRequest.Put("https://catbingochild.azurewebsites.net/api/CatBingoState", myData);
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();
        Debug.Log("upload sent");
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("put error: "+www.error);
        }
        else
        {
            Debug.Log("Upload complete!");
            Debug.Log(state.apple);
            Debug.Log(state.guava);
            Debug.Log(state.watermelon);
            Debug.Log(state.orange);
        }
        www.Dispose();
    }
}


