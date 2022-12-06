using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Hint : MonoBehaviour
{
    int E_Min = 0;
    int E_Max = 30;
    int Mid_Min = 31;
    int Mid_Max = 99;
    int Hard_Min = 100;
    int Hard_Max = 999;
    public TMP_Text operand1;
    public TMP_Text operand2;
    public TMP_Text ans1;
    public TMP_Text ans2;
    public TMP_Text ans3;
    // public static int level_parameter;
    int temp = 0;
    // Start is called before the first frame update
    void Start()
    {
        temp = Int32.Parse(operand1.text) - Int32.Parse(operand2.text);
        // ans1.text = temp.ToString();
        Debug.Log("parameter"+GMScript.level_parameter);
        if (GMScript.level_parameter == 1)
        {
            int num1 = UnityEngine.Random.Range(E_Min, E_Max); 
            int num2 = UnityEngine.Random.Range(E_Min, E_Max);  
            ans1.text = num1.ToString();
            ans2.text = num2.ToString();
            ans3.text = temp.ToString();
        }
        else if (GMScript.level_parameter == 2)
        {
            int num1 = UnityEngine.Random.Range(Mid_Min, Mid_Max); 
            int num2 = UnityEngine.Random.Range(Mid_Min, Mid_Max);  
            ans1.text = num1.ToString();
            ans2.text = num2.ToString();
            ans3.text = temp.ToString();
        }
        else if (GMScript.level_parameter == 3)
        {
            int num1 = UnityEngine.Random.Range(Hard_Min, Hard_Max); 
            int num2 = UnityEngine.Random.Range(Hard_Min, Hard_Max);  
            ans1.text = num1.ToString();
            ans2.text = num2.ToString();
            ans3.text = temp.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
