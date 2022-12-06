using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using TMPro;
using UnityEngine.EventSystems;

public class Fruitinc : MonoBehaviour
{
    //public RawImage RawImage;
    // Use this for initialization
    /*void Start()
	{
		sprite = Resources.Load<Sprite>("apple");

		GameObject image = GameObject.Find("Image");
		image.GetComponent<Image>().sprite = sprite;
	}
	//Texture2D myTexture;
	
	// Use this for initialization*/
    public TMP_Text applecount;
    public TMP_Text meloncount;
    public TMP_Text orangecount;
    public TMP_Text guavacount;
    public int fruit_counter = 0;
    /*public int count1;
	public int count2;
	public int count3;
	public int count4;
	public int acount;*/

    void Start()
    {
        //Texture2D myTexture;
        //RawImage.enabled = false;

        //if (clickControll.over == true)
        //{
        //    Debug.Log("applecount count:" + Game_state.apple);
            // load texture from resource folder			
            //myTexture = Resources.Load("apple-removebg-preview") as Texture2D;
            //GameObject apple = GameObject.Find("apple");
            //apple.GetComponent<apple>().texture = myTexture;
            //count1 = clickControll.applebingoinc;
            //applecount.text = count1.ToString();

            applecount.text = Game_state.apple.ToString();


        //}
        //if (clickControll.over1 == true)
        //{
        //    Debug.Log("applecount count:" + Game_state.guava);
            //count2 = clickControll.guavabingoinc;
            //guavacount.text = count2.ToString();
            guavacount.text = Game_state.guava.ToString();
        //}
        //if (clickControll.over2 == true)
        //{
        //    Debug.Log("applecount count:" + Game_state.watermelon);
            //count3 = clickControll.melonbingoinc;
            //meloncount.text = count3.ToString();
            meloncount.text = Game_state.watermelon.ToString();
        //}
        //if (clickControll.over3 == true)
        //{
            //count4 = clickControll.orangebingoinc;
            //orangecount.text = count4.ToString();
            //Debug.Log("applecount count:" + Game_state.orange);
            orangecount.text = Game_state.orange.ToString();
        //}

        /*if(Drag.x!= count4)
        {
			orangecount.text = Drag.x.ToString();
		}
		if (Drag.y != count1)
		{
			applecount.text = Drag.y.ToString();
		}
		if (Drag.z != count3)
		{
			meloncount.text = Drag.z.ToString();
		}
		if (Drag.s != count2)
		{
			guavacount.text = Drag.s.ToString();
		}
		*/
        //      else
        //      {
        //	applecount.text = fruit_counter.ToString();
        //	meloncount.text = clickControll.melonbingoinc.ToString();
        //	orangecount.text = clickControll.orangebingoinc.ToString();
        //	guavacount.text = clickControll.guavabingoinc.ToString();
        //}
    }
    //RawImage.enabled = true;
    //rawImage.gameObject.SetActive(true);\
    /*Texture2D myTexture1;
	if (clickControll.over == true)
	{
		myTexture1 = Resources.Load("guava") as Texture2D;
		GameObject rawImage1 = GameObject.Find("RawImage1");
		rawImage1.GetComponent<RawImage1>().texture = myTexture1;
	}*/

}
