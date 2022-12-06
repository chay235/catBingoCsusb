using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectplayerpopup : MonoBehaviour
{
    public GameObject inputField;
    public GameObject playerScroller;
   
    public void popup()
    {
        inputField.SetActive(true);
        playerScroller.SetActive(false);
    }
        
}
