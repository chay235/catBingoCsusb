using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Report_score_script : MonoBehaviour
{
    public int category;
    public TMP_Text report_text;
    public TMP_Text progress;
    public static bool reset_parameter = false;
    public int c = 0;
    public GameObject whiteCircle;
    // Start is called before the first frame update
    void Start()
    {
        int total_questions;
        int total_answers;
        //Debug.Log("in report_score_script"+category);
        switch (category + 1)
        {
            case 1:
                total_questions = Game_state.Qcategory1;
                total_answers = Game_state.Acategory1;
                break;
            case 2:
                total_questions = Game_state.Qcategory2;
                total_answers = Game_state.Acategory2;
                break;
            case 3:
                total_questions = Game_state.Qcategory3;
                total_answers = Game_state.Acategory3;
                break;
            case 4:
                total_questions = Game_state.Qcategory4;
                total_answers = Game_state.Acategory4;
                break;
            case 5:
                total_questions = Game_state.Qcategory5;
                total_answers = Game_state.Acategory5;
                break;
            case 6:
                total_questions = Game_state.Qcategory6;
                total_answers = Game_state.Acategory6;
                break;
            case 7:
                total_questions = Game_state.Qcategory7;
                total_answers = Game_state.Acategory7;
                break;
            case 8:
                total_questions = Game_state.Qcategory8;
                total_answers = Game_state.Acategory8;
                break;
            case 9:
                total_questions = Game_state.Qcategory9;
                total_answers = Game_state.Acategory9;
                break;
            case 10:
                total_questions = Game_state.Qcategory10;
                total_answers = Game_state.Acategory10;
                break;
            case 11:
                total_questions = Game_state.Qcategory11;
                total_answers = Game_state.Acategory11;
                break;
            case 12:
                total_questions = Game_state.Qcategory12;
                total_answers = Game_state.Acategory12;
                break;
            case 13:
                total_questions = Game_state.Qcategory13;
                total_answers = Game_state.Acategory13;
                break;
            case 14:
                total_questions = Game_state.Qcategory14;
                total_answers = Game_state.Acategory14;
                break;
            case 15:
                total_questions = Game_state.Qcategory15;
                total_answers = Game_state.Acategory15;
                break;
            case 16:
                total_questions = Game_state.Qcategory16;
                total_answers = Game_state.Acategory16;
                break;
            case 17:
                total_questions = Game_state.Qcategory17;
                total_answers = Game_state.Acategory17;
                break;
            default:
                total_questions = 0;
                total_answers = 0;
                break;
        }
        if (total_questions > 0)
        {
            report_text.text = "Answered correctly " + total_answers + " out of " + total_questions + " times.";
            progress.text = (total_answers*100 / total_questions).ToString() + "%";
            int progressint = total_answers * 100 / total_questions;

            
            if (progressint > 90)
            {
                whiteCircle.GetComponent<Image>().color = new Color32(153, 255, 0, 255); 
            }
            else if (progressint > 70 && progressint <= 90)
            {
                whiteCircle.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
            }
            else if (progressint > 50 && progressint <= 70)
            {
                whiteCircle.GetComponent<Image>().color = new Color32(191, 80, 14, 255);
            }
            else
            {
                whiteCircle.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            }
            progress.color = new Color(0, 0, 0, 255);
        }
        else
        {
            report_text.text = "Keep on learning! Check back to see your child's progress.";
            progress.text = "";
            whiteCircle.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }
        

    }

    void Update()
    {
        //Debug.Log(c);
        if (reset_parameter == true)
        {
            Debug.Log("in update method!");
            report_text.text = "Keep on learning! Check back to see your child's progress.";
            progress.text = "";
            whiteCircle.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }
    }

    //public void reset_report_scores()
    //{
    //    Debug.Log("in reset method!");
    //    reset_parameter = true;
    //}


}
