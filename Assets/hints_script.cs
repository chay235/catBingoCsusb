using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hints_script : MonoBehaviour
{
    public TMP_Text operand1;
    public TMP_Text operand2;
    public TMP_Text endtext;

    void Start()
    {
        endtext.text = operand1.text;
    }

}