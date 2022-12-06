using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditNameButtonClick : MonoBehaviour
{
    public GameObject go;
    public void editButtonClicked()
    {
        go.SetActive(true);
    }
}
