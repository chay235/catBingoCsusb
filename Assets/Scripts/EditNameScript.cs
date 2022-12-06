using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditNameScript : MonoBehaviour
{
    public TMP_Text name_text;
    public void edit_name()
    {
        string name = name_text.text;
        Game_state.name=name.Substring(0, name.Length - 1);
        SceneManager.LoadScene(6);
    }
}
