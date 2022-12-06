using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Drag : MonoBehaviour
{
    [SerializeField]

    private Canvas canvas;
    public GameObject apple;
    public GameObject orange;
    public GameObject watermelon;
    public GameObject guava;

    public GameObject appleaxis;
    public GameObject orangeaxis;
    public GameObject melonaxis;
    public GameObject guavaaxis;

    public TMP_Text applecount;
    public TMP_Text meloncount;
    public TMP_Text orangecount;
    public TMP_Text guavacount;

    public static int apples_final;
    public static int oranges_final;
    public static int guavas_final;
    public static int melons_final;

    public float appleX_old;
    public float appleY_old;
    public float orangeX_old;
    public float orangeY_old;
    public float melonX_old;
    public float melonY_old;
    public float guavaX_old;
    public float guavaY_old;


    public void Start()
    {
        // startingObject = GameObject.Find("Starting"); //Find it here, or drag it into the hierarchy

        appleaxis = GameObject.Find("apple");
        melonaxis = GameObject.Find("watermelon");
        guavaaxis = GameObject.Find("guava");
        orangeaxis = GameObject.Find("orange");

        apples_final = GMScript.applecount;
        oranges_final = GMScript.orangecount;
        melons_final = GMScript.meloncount;
        guavas_final = GMScript.guavacount;

         appleX_old = appleaxis.transform.position.x;
         appleY_old = appleaxis.transform.position.y;

         orangeX_old = orangeaxis.transform.position.x;
         orangeY_old = orangeaxis.transform.position.y;
       
         melonX_old = melonaxis.transform.position.x;
         melonY_old = melonaxis.transform.position.y;

         guavaX_old = guavaaxis.transform.position.x;
         guavaY_old = guavaaxis.transform.position.y;
    }

     
    public void DragHandler(BaseEventData data)
    {

        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
             pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);

        Debug.Log("apples+oranges+guava+melons"+apples_final+";"+oranges_final+";"+guavas_final+";"+melons_final);
        //appleaxis = GameObject.Find("apple");
        float appleX = appleaxis.transform.position.x;
        float appleY = appleaxis.transform.position.y;
        //float appleY = (GameObject.Find("apple").transform.position.y);
        Debug.Log("test2");
        //orangeaxis = GameObject.Find("orange");
        //  float orangeX = (GameObject.Find("orange").transform.position.x);
        //  float orangeY = (GameObject.Find("orange").transform.position.y);
        float orangeX = orangeaxis.transform.position.x;
        float orangeY = orangeaxis.transform.position.y;
        Debug.Log("test3");
        //  float melonX = (GameObject.Find("watermelon").transform.position.x);
        //  float melonY = (GameObject.Find("watermelon").transform.position.y);

        float melonX = melonaxis.transform.position.x;
        float melonY = melonaxis.transform.position.y;

        Debug.Log("test4");
        //  float guavaX = (GameObject.Find("guava").transform.position.x);
        //  float guavaY = (GameObject.Find("guava").transform.position.y);

        float guavaX = guavaaxis.transform.position.x;
        float guavaY = guavaaxis.transform.position.y;


        float catXmin = (GameObject.Find("Cateating").transform.position.x);
        float catYmin = (GameObject.Find("Cateating").transform.position.y);
        float catXmax = catXmin + 100;
        catYmin = catYmin + 100;
        float catYmax = catYmin - 100;
        Debug.Log(transform.position);
        //if (clickControll.orangebingoinc == 0)
        //{
        
        if (orangeX > catXmin && orangeX < catXmax && orangeY < catYmin && orangeY > catYmax)
        {

            //orange.SetActive(false);
            orange.transform.position = new Vector2(orangeX_old, orangeY_old);
            //orangeaxis.transform.position = new Vector3(orangeX, orangeY, orangeaxis.transform.position.z);
            //Fruitinc.orangecount = (clickControll.orangebingoinc - 1).ToString();
            Debug.Log("orange" + orangeX + "," + orangeY + ",cat x:" + catXmin + ",cat x:" + catXmax + ",cat y:" + catYmin + ",cat y:" + catYmax);
            
            orangecount.text =(oranges_final-1).ToString();
            oranges_final = oranges_final - 1;

            
        }
        //}
        //  if (clickControll.applebingoinc != 0)
        //{
        if (appleX > catXmin && appleX < catXmax && appleY < catYmin && appleY > catYmax)
        {
           
                Debug.Log("apple" + appleX + "," + appleY + ",cat x:" + catXmin + ",cat x:" + catXmax + ",cat y:" + catYmin + ",cat y:" + catYmax);
            //apple.SetActive(false);
            apple.transform.position = new Vector2(appleX_old, appleY_old);
            //  int y = clickControll.applebingoinc - 1;

            applecount.text = (apples_final-1).ToString();
            apples_final = apples_final - 1;
 

                 //Game_state.apple = Game_state.apple - 1;
                //Fruitinc.acount = (clickControll.applebingoinc - 1)

            
            // fruit.SetActive(true);

        }
        //}
        //if (clickControll.melonbingoinc != 0)
        //{


        if (melonX > catXmin && melonX < catXmax && melonY < catYmin && melonY > catYmax)
        {
            //watermelon.SetActive(false);
            watermelon.transform.position = new Vector2(melonX_old, melonY_old);
            //melonaxis.transform.position = new Vector3(melonX, melonY, melonaxis.transform.position.z);
            //int z = clickControll.melonbingoinc - 1;
            Debug.Log("melon" + melonX + "," + melonY + ",cat x:" + catXmin + ",cat x:" + catXmax + ",cat y:" + catYmin + ",cat y:" + catYmax);
            meloncount.text = (melons_final - 1).ToString();

            melons_final = melons_final - 1;
            Debug.Log("hello eat");

            // fruit.SetActive(true);

        }
        // }
        //if (clickControll.guavabingoinc != 0)
        //{
       if (guavaX > catXmin && guavaX < catXmax && guavaY < catYmin && guavaY > catYmax)
        {
            //guavaaxis.transform.position = new Vector3(guavaX, guavaY, guavaaxis.transform.position.z);
            //guava.SetActive(false);
            guava.transform.position = new Vector2(guavaX_old, guavaY_old);
            //int s = clickControll.guavabingoinc - 1;
            Debug.Log("guava");
            Debug.Log("guava" + guavaX + "," + guavaX + ",cat x:" + catXmin + ",cat x:" + catXmax + ",cat y:" + catYmin + ",cat y:" + catYmax);

            guavacount.text = (guavas_final- 1).ToString();

         
            guavas_final=guavas_final-1;
            Debug.Log("hello eat");

            // fruit.SetActive(true);

        }
        // }

    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour
{
    [SerializeField]

    private Canvas canvas;
    public GameObject fruit;

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
             pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);
        float catXmin = (GameObject.Find("Cateating").transform.position.x);
        float catYmin = (GameObject.Find("Cateating").transform.position.y);
        float catXmax = catXmin + 50;
        catYmin = catYmin + 50;
        float catYmax = catYmin - 100;
        // Debug.Log(catXmin, catXmax, catYmin, catYmax);
        Debug.Log(transform.position);
        if (transform.position.x > catXmin && transform.position.x < catXmax && transform.position.y < catYmin && transform.position.y > catYmax)
        {
            fruit.SetActive(false);
        }
    }
}*/