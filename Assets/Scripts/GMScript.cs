using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    int E_MinL1 = 0;
    int E_MaxL1 = 10;
    int E_MinL2 = 11;
    int E_MaxL2 = 20;
    int E_MinL3 = 21;
    int E_MaxL3 = 30;

    int Mid_MinL1 = 31;
    int Mid_MaxL1 = 45;
    int Mid_MinL2 = 46;
    int Mid_MaxL2 = 70;
    int Mid_MinL3 = 71;
    int Mid_MaxL3 = 99;

    int Hard_MinL1 = 100;
    int Hard_MaxL1 = 300;
    int Hard_MinL2 = 301;
    int Hard_MaxL2 = 600;
    int Hard_MinL3 = 601;
    int Hard_MaxL3 = 999;
    public static int level_parameter;
    public static int index = 0;
    public static int row1 = 0;
    public static int row2 = 0;
    public static int row3 = 0;
    public static int row4 = 0;
    public static int row5 = 0;
    public static int col1 = 0;
    public static int col2 = 0;
    public static int col3 = 0;
    public static int col4 = 0;
    public static int col5 = 0;
    public static int diag1 = 0;
    public static int diag2 = 0;
    public static int[] test = new int[25];
    public static int[] tempans = new int[25];
    public static int[] Indarray;
    public static int[] operator1;
    public static int[] operator2;
    public static int[] result;
    //public static int[] questions_types_total = new int[17]{Game_state.Qcategory1,Game_state.Qcategory2, Game_state.Qcategory3, Game_state.Qcategory4, Game_state.Qcategory5, Game_state.Qcategory6, Game_state.Qcategory7, Game_state.Qcategory8, Game_state.Qcategory9, Game_state.Qcategory10, Game_state.Qcategory11, Game_state.Qcategory12, Game_state.Qcategory13, Game_state.Qcategory14, Game_state.Qcategory15, Game_state.Qcategory16, Game_state.Qcategory17};
    //public static int[] answers_types_total = new int[17] { Game_state.Acategory1, Game_state.Acategory2, Game_state.Acategory3, Game_state.Acategory4, Game_state.Acategory5, Game_state.Acategory6, Game_state.Acategory7, Game_state.Acategory8, Game_state.Acategory9, Game_state.Acategory10, Game_state.Acategory11, Game_state.Acategory12, Game_state.Acategory13, Game_state.Acategory14, Game_state.Acategory15, Game_state.Acategory16, Game_state.Acategory17 };
    public TMP_Text operator1_handler;
    public TMP_Text operand1_handler;
    public TMP_Text operand2_handler;
    public Image image;
    public static int[] wrongans;
    public static int applecount;
    public static int orangecount;
    public static int meloncount;
    public static int guavacount;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game_stateScores for "+ Game_state.name+" "+Game_state.EasyScore + " " + Game_state.MediumScore + " " + Game_state.HardScore);
        index = 0;
        row1 = 0;
        row2 = 0;
        row3 = 0;
        row4 = 0;
        row5 = 0;
        col1 = 0;
        col2 = 0;
        col3 = 0;
        col4 = 0;
        col5 = 0;
        diag1 = 0;
        diag2 = 0;
        Indarray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        operator1 = new int[25];
        operator2 = new int[25];
        result = new int[25];
        wrongans = new int[12];

        applecount = Game_state.apple;
        meloncount = Game_state.watermelon;
        orangecount = Game_state.orange;
        guavacount = Game_state.guava;
        Debug.Log("gm");
        Debug.Log("level_parameter:"+level_parameter);
        System.Random random = new System.Random();
        for (int i = 0; i < 25; i++)
        {
            if (level_parameter == 1)
            {
                if (Game_state.EasyScore < 10)
                {
                    operator1[i] = UnityEngine.Random.Range(E_MinL1, E_MaxL1);
                    operator2[i] = UnityEngine.Random.Range(E_MinL1, operator1[i]);
                }
                else if(Game_state.EasyScore > 10 && Game_state.EasyScore < 20)
                {
                    operator1[i] = UnityEngine.Random.Range(E_MinL2, E_MaxL2);
                    operator2[i] = UnityEngine.Random.Range(E_MinL2, operator1[i]);
                }
                else
                {
                    operator1[i] = UnityEngine.Random.Range(E_MinL3, E_MaxL3);
                    operator2[i] = UnityEngine.Random.Range(E_MinL3, operator1[i]);
                }
            }
            else if (level_parameter == 2)
            {

                if (Game_state.MediumScore < 10)
                {
                    operator1[i] = UnityEngine.Random.Range(Mid_MinL1, Mid_MaxL1);
                    operator2[i] = UnityEngine.Random.Range(Mid_MinL1, operator1[i]);
                }
                else if (Game_state.MediumScore > 10 && Game_state.MediumScore < 20)
                {
                    operator1[i] = UnityEngine.Random.Range(Mid_MinL2, Mid_MaxL2);
                    operator2[i] = UnityEngine.Random.Range(Mid_MinL2, operator1[i]);
                }
                else
                {
                    operator1[i] = UnityEngine.Random.Range(Mid_MinL3, Mid_MaxL3);
                    operator2[i] = UnityEngine.Random.Range(Mid_MinL3, operator1[i]);
                }

            }
            else if (level_parameter == 3)
            {
                if (Game_state.HardScore < 10)
                {
                    operator1[i] = UnityEngine.Random.Range(Hard_MinL1, Hard_MaxL1);
                    operator2[i] = UnityEngine.Random.Range(Hard_MinL1, operator1[i]);
                }
                else if (Game_state.HardScore > 10 && Game_state.HardScore < 20)
                {
                    operator1[i] = UnityEngine.Random.Range(Hard_MinL2, Hard_MaxL2);
                    operator2[i] = UnityEngine.Random.Range(Hard_MinL2, operator1[i]);
                }
                else
                {
                    operator1[i] = UnityEngine.Random.Range(Hard_MinL3, Hard_MaxL3);
                    operator2[i] = UnityEngine.Random.Range(Hard_MinL1, operator1[i]);
                }


            }
            tempans[i] = operator1[i] - operator2[i];
            
            
        }

        System.Random rnd = new System.Random();
        Indarray = Indarray.OrderBy(x => rnd.Next()).ToArray();

        for(int i = 0; i < 25; i++)
        {
            test[i] = tempans[Indarray[i]];
        }

        String[] o1 = Array.ConvertAll(operator1, x => x.ToString());
        String[] o2 = Array.ConvertAll(operator2, x => x.ToString());
        String[] o3 = Array.ConvertAll(tempans, x => x.ToString());
        String[] o4 = Array.ConvertAll(Indarray, x => x.ToString());

        String[] t = Array.ConvertAll(test, x => x.ToString());
        
        Debug.Log(String.Join(",", o1));
        Debug.Log(String.Join(",", o2));
        Debug.Log("answer in order" + String.Join(",", o3));
        Debug.Log("array index" + String.Join(",", o4));
        Debug.Log("answers showed" + String.Join(",", t));
        
        

        image.enabled = false;
    }
}
