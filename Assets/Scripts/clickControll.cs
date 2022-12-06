using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.PlayerSettings;
using UnityEngine.SceneManagement;

public class clickControll : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update

    public TMP_Text num1text;
    public int index;
    public TMP_Text operand1text;
    public TMP_Text operand2text;
    public Button button;
    public Image image;
    public Image bingo_image;

    public static bool over = false;
    public static bool over1 = false;
    public static bool over2 = false;
    public static bool over3 = false;
    //public static int applebingoinc = Game_state.apple;
    //public static int melonbingoinc = Game_state.watermelon;
    //public static int guavabingoinc = Game_state.guava;
    //public static int orangebingoinc = Game_state.orange;
    int E_Min = 0;
    int E_Max = 30;
    int Mid_Min = 31;
    int Mid_Max = 99;
    int Hard_Min = 100;
    int Hard_Max = 999;
    public TMP_Text hint1;
    public TMP_Text hint2;
    public TMP_Text hint3;
    public static int[] shuffleArr = new int[3];
    public static bool h1 = true;
    public static bool h2 = true;
    public static bool h3 = true;
    public static bool h4 = true;
    public static bool h5 = true;
    public static bool v1 = true;
    public static bool v2 = true;
    public static bool v3 = true;
    public static bool v4 = true;
    public static bool v5 = true;
    public static bool dia1 = true;
    public static bool dia2 = true;
    public GameObject operand1;
    public GameObject operand2;
    public GameObject operator1;
    public GameObject hint;
    public GameObject exit;
    public GameObject congratulations;
    public GameObject nomoremoves;
    public static int applecount;
    public static int orangecount;
    public static int meloncount;
    public static int guavacount;

    void Start()
    {
        //Debug.Log("cc"+index);
        num1text.text = GMScript.test[index].ToString();
        image.enabled = false;
    }
   

    public void OnPointerClick(PointerEventData eventData)
    {
        int temp = 0;
        temp = GMScript.operator1[GMScript.index + 1] - GMScript.operator2[GMScript.index + 1];
        // ans1.text = temp.ToString();
        for (int i = 0; i < 2; i++)
        {
            if (GMScript.level_parameter == 1)
            {
                int range1 = UnityEngine.Random.Range(E_Min, E_Max);
                shuffleArr[i] = range1;
            }
            else if (GMScript.level_parameter == 2)
            {
                int range2 = UnityEngine.Random.Range(Mid_Min, Mid_Max);
                shuffleArr[i] = range2;
            }
            else if (GMScript.level_parameter == 3)
            {
                int range3 = UnityEngine.Random.Range(Hard_Min, Hard_Max);
                shuffleArr[i] = range3;
            }
        }
        shuffleArr[2] = temp;
        System.Random rnd = new System.Random();
        shuffleArr = shuffleArr.OrderBy(x => rnd.Next()).ToArray();
        hint1.text = shuffleArr[0].ToString();
        hint2.text = shuffleArr[1].ToString();
        hint3.text = shuffleArr[2].ToString();

        int currquesint = GMScript.index;
        int o1 = GMScript.operator1[currquesint];
        int o2 = GMScript.operator2[currquesint];

        //Debug.Log("in click control");
        if(o2==0 || o2==1){
            Game_state.Qcategory1 += 1;
            if(GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory1 += 1;
            }
        }
        if (o1 == o2 * 2 && o1<10)
        {
            Game_state.Qcategory2 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory2 += 1;
            }
        }
        if(o1 == o2 * 2 && o1 >= 10 && o1 <= 99)
        {
            Game_state.Qcategory3 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory3 += 1;
            }
        }
        if (o1 == 10)
        {
            Game_state.Qcategory4 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory4 += 1;
            }
        }
        if(o1>=10 && o1<=20 && o2 == 10)
        {
            Game_state.Qcategory5 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory5 += 1;
            }
        }
        if (o1 == o2 * 2 + 1)
        {
            Game_state.Qcategory6 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory6 += 1;
            }
        }
        if(o1==9 || o1 == 11)
        {
            Game_state.Qcategory7 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory7 += 1;
            }
        }
        if (o1 == o2 - 2)
        {
            Game_state.Qcategory8 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory8 += 1;
            }
        }
        if(o2==2)
        {
            Game_state.Qcategory9 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory9 += 1;
            }
        }
        if (o2 == 10)
        {
            Game_state.Qcategory10 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory10 += 1;
            }
        }
        if (o1<20)
        {
            Game_state.Qcategory11 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory11 += 1;
            }
        }
        if(o1>=20 && o1 <= 30)
        {
            Game_state.Qcategory12 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory12 += 1;
            }
        }
        if (o1 > 30 && o1 <= 50)
        {
            Game_state.Qcategory13 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory13 += 1;
            }
        }
        if (o1 > 50 && o1 <= 100)
        {
            Game_state.Qcategory14 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory14 += 1;
            }
        }
        if (o2 >= 10 && o2 <= 99)
        {
            Game_state.Qcategory15 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory15 += 1;
            }
        }
        if (o1 >= 100 && o2 >= 10 && o2 <= 99)
        {
            Game_state.Qcategory16 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory16 += 1;
            }
        }
        if(o1>=100 && o2 >= 100)
        {
            Game_state.Qcategory17 += 1;
            if (GMScript.test[index] == o1 - o2)
            {
                Game_state.Acategory17 += 1;
            }
        }


        if (GMScript.test[index] == o1-o2)
        {

            //Debug.Log("correct ans");
            //button.GetComponent<Image>().sprite= image;
            image.enabled = true;
            //num1text.text = "";
            //GMScript.result[GMScript.Indarray[GMScript.index]] = 1;
            GMScript.result[GMScript.index] = 1;
            //button.GetComponent<Button>().interactable = false;
            if (GMScript.level_parameter == 1)
            {
                Game_state.EasyScore = Game_state.EasyScore + 1;
            }
            else if (GMScript.level_parameter == 2)
            {
                Game_state.MediumScore = Game_state.MediumScore + 1;
            }
            else
            {
                Game_state.HardScore = Game_state.HardScore + 1;
            }

            //for bingo detection
            if (index!=0 & index!=24 & index % 4 == 0)
            {
                GMScript.diag1 += 1;
                if (GMScript.diag1 == 5)
                {
                    applebingoresponse();
                }
            }
            if (index % 6 == 0)
            {
                GMScript.diag2 += 1;
                if (GMScript.diag2 == 5)
                {
                    orangebingoresponse();
                }
            }

            switch (index % 5){
                case 0:
                    GMScript.col1 += 1;
                    //Debug.Log("C count:-----------"+c1);
                    if (GMScript.col1 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("C count:-----------" + c2);
                    GMScript.col2 += 1;
                    if (GMScript.col2 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 2:
                    //Debug.Log("C count:-----------" + c3);
                    GMScript.col3 += 1;
                    if (GMScript.col3 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 3:
                    GMScript.col4 += 1;
                    if (GMScript.col4 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                case 4:
                    GMScript.col5 += 1;
                    if (GMScript.col5 == 5)
                    {
                        guavabingoresponse();
                    }
                    break;
                default:
                    break;
            }
            switch (index/5)
            {
                case 0:
                    GMScript.row1 += 1;
                    //Debug.Log("R count:-----------" + r1);
                    if (GMScript.row1 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 1:
                    //Debug.Log("R count:-----------" + r2);
                    GMScript.row2 += 1;
                    if (GMScript.row2 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 2:
                    GMScript.row3 += 1;
                    if (GMScript.row3 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 3:
                    GMScript.row4 += 1;
                    if (GMScript.row4 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                case 4:
                    GMScript.row5 += 1;
                    if (GMScript.row5 == 5)
                    {
                        melonbingoresponse();
                    }
                    break;
                default:
                    break;
            }
        }

        //for wrong answers
        else
        {
            if (index - 1 == 0)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
            else if (index - 1 == 1)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
            }
            else if (index - 1 == 2)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 3)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
            }
            else if (index - 1 == 4)
            {
                if (h1 == true)
                {
                    h1 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 5)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
            }
            else if (index - 1 == 6)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
            else if (index - 1 == 7)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 8)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 9)
            {
                if (h2 == true)
                {
                    h2 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
            }
            else if (index - 1 == 10)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
            }
            else if (index - 1 == 11)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
            }
            else if (index - 1 == 12)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 13)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
            }
            else if (index - 1 == 14)
            {
                if (h3 == true)
                {
                    h3 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
            }
            else if (index - 1 == 15)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
            }
            else if (index - 1 == 16)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 17)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 18)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
            else if (index - 1 == 19)
            {
                if (h4 == true)
                {
                    h4 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
            }
            else if (index - 1 == 20)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v1 == true)
                {
                    v1 = false;
                }
                if (dia2 == true)
                {
                    dia2 = false;
                }
            }
            else if (index - 1 == 21)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v2 == true)
                {
                    v2 = false;
                }
            }
            else if (index - 1 == 22)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v3 == true)
                {
                    v3 = false;
                }
            }
            else if (index - 1 == 23)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v4 == true)
                {
                    v4 = false;
                }
            }
            else if (index - 1 == 24)
            {
                if (h5 == true)
                {
                    h5 = false;
                }
                if (v5 == true)
                {
                    v5 = false;
                }
                if (dia1 == true)
                {
                    dia1 = false;
                }
            }
            /*
            if (index != 0 & index != 24 & index % 4 == 0)
            {
                GMScript.wrongans[10] += 1;
            }
            if (index % 6 == 0)
            {
                GMScript.wrongans[11] += 1;
            }

            switch (index % 5)
            {
                case 0:
                    GMScript.wrongans[0] += 1;
                    break;
                case 1:
                    GMScript.wrongans[1] += 1;
                    break;
                case 2:
                    GMScript.wrongans[2] += 1;
                    break;
                case 3:
                    GMScript.wrongans[3] += 1;
                    break;
                case 4:
                    GMScript.wrongans[4] += 1;
                    break;
                default:
                    break;
            }
            switch (index / 5)
            {
                case 0:
                    GMScript.wrongans[5] += 1;
                    break;
                case 1:
                    GMScript.wrongans[6] += 1;
                    break;
                case 2:
                    GMScript.wrongans[7] += 1;
                    break;
                case 3:
                    GMScript.wrongans[8] += 1;
                    break;
                case 4:
                    GMScript.wrongans[9] += 1;
                    break;
                default:
                    break;
            }*/
            //button.GetComponent<Button>().interactable = false;
            //GMScript.result[GMScript.Indarray[GMScript.index]] =2;
            //int wronglines = 0;
            int currnum = GMScript.test[index];
            for (int i = 0;i< 24; i++)
            {
                //if (i<12 && GMScript.wrongans[i] >= 1)
                //{
                //    wronglines++;
                //}
                if ((GMScript.operator1[i] - GMScript.operator2[i])==currnum && GMScript.result[i] == 0)
                {
                    GMScript.result[i] = 2;
                    break;
                }
            }
            Bingo();
            //if (wronglines == 12)
            //{
            //    Debug.Log("no more moves");
            //}
            Debug.Log("null answer index"+GMScript.Indarray[index]);
            button.gameObject.SetActive(false);

            //Debug.Log("incorrect ans");
        }
        Debug.Log("index"+index);

        int currind = GMScript.index;
        while (currind < 24)
        {
            string[] res = Array.ConvertAll(GMScript.result, x => x.ToString());
            Debug.Log(String.Join(",",res));
            if (GMScript.result[currind + 1] == 2)
            {
                Debug.Log("null question index" + currind);
                currind++;
                
            }
            else
            {

                GMScript.index = currind + 1;
                operand1text.text = GMScript.operator1[currind + 1].ToString();
                operand2text.text = GMScript.operator2[currind + 1].ToString();
                break;
            }
        }
        
        //GMScript.index = currquesint+1;
        //if (currquesint < 24) {
        //    operand1text.text = GMScript.operator1[currquesint+1].ToString();
        //    operand2text.text = GMScript.operator2[currquesint+1].ToString();
        //}
        //Debug.Log("button number" + index + " clicked");
    }
    //public void buttontesting()
    //{
    //    Debug.Log("button"+index+"clicked!");
    //}

    public void Bingo()
    {
        if (h1 == false && h2 == false && h3 == false && h4 == false && h5 == false && v1 == false && v2 == false && v3 == false
            && v4 == false && v5 == false && dia1 == false && dia2 == false)
        {
            operand1.SetActive(false);
            operand2.SetActive(false);
            operator1.SetActive(false);
            hint.SetActive(false);
            nomoremoves.SetActive(true);
            exit.SetActive(true);

            //string bingoOrNot = "NOT BINGO";
            //StartCoroutine(SceneLoader(bingoOrNot));
        }
    }
/*    IEnumerator SceneLoader(string bingoOrNot)
    {
        if (bingoOrNot == "BINGO")
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("LevelScreen");
        }
    }*/
    public void applebingoresponse()
    {


        Debug.Log("from apple Bingo: "+Game_state.apple);
        bingo_image.enabled = true;
        over = true;
        Game_state.apple = Game_state.apple + 1;
        applecount = Game_state.apple;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
       // StartCoroutine(SceneLoader(bingoOrNot));
    }
    public void guavabingoresponse()
    {
        //Debug.Log("Bingo");
        Debug.Log("from apple Bingo: " + Game_state.guava);
        bingo_image.enabled = true;
        over1 = true;
        Game_state.guava = Game_state.guava + 1;
        GMScript.guavacount = Game_state.guava;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
       // StartCoroutine(SceneLoader(bingoOrNot));
    }

    public void melonbingoresponse()
    {
        //Debug.Log("Bingo");
        Debug.Log("from apple Bingo: " + Game_state.watermelon);
        bingo_image.enabled = true;
        over2 = true;
        Game_state.watermelon = Game_state.watermelon + 1;
        GMScript.meloncount = Game_state.watermelon;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
       // StartCoroutine(SceneLoader(bingoOrNot));
    }

    public void orangebingoresponse()
    {
        //Debug.Log("Bingo");
        Debug.Log("from apple Bingo: " + Game_state.orange);
        bingo_image.enabled = true;
        over3 = true;
        Game_state.orange = Game_state.orange + 1;
        GMScript.orangecount = Game_state.orange;
        operand1.SetActive(false);
        operand2.SetActive(false);
        operator1.SetActive(false);
        hint.SetActive(false);
        congratulations.SetActive(true);
        string bingoOrNot = "BINGO";
       // StartCoroutine(SceneLoader(bingoOrNot));
    }

    public void bingoresponse()
    {
        //Debug.Log("Bingo");
        bingo_image.enabled = true;
    }

    
}
