using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class player_name_assignment : MonoBehaviour
{
    public TMP_Text name_text;
    // Start is called before the first frame update
    void Start()
    {
        name_text.text = Game_state.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
