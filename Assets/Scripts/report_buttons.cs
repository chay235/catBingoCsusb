using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class report_buttons : MonoBehaviour
{
    public void edit_name()
    {

    }

    public void Reset_report()
    {
        Report_score_script.reset_parameter = true;
        Debug.Log("in reset button");
    }

    public void Delete_player()
    {

    }
}
