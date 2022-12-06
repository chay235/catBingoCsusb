using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DD : MonoBehaviour,  IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform m_RectTransform;
    private CanvasGroup m_CanvasGroup;
    public int x_position;
    public TMP_Text applecount;
    public TMP_Text meloncount;
    public TMP_Text orangecount;
    public TMP_Text guavacount;
    public GameObject fruitaxis;

    Vector2 fruitcoords;
    
    //Awake is called when the script instance is being loaded
    void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
        m_CanvasGroup = GetComponent<CanvasGroup>();
        fruitcoords =new Vector2(fruitaxis.transform.position.x, fruitaxis.transform.position.y);
        
    }
    //This method is called when the gameobject drag is started
    public void OnBeginDrag(PointerEventData eventData)
    {
            m_CanvasGroup.blocksRaycasts = false;
    }
    //This method is called when the gameobject is being dragged
    public void OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    //This method is called when the game object is dropped
    public void OnEndDrag(PointerEventData eventData)
    {
        StartCoroutine(SceneLoader());
        m_CanvasGroup.blocksRaycasts = true;   
    }
    IEnumerator SceneLoader()
    {
        yield return new WaitForSeconds(3.5f);
        //gameObject.SetActive(false);
        fruitaxis.transform.position = fruitcoords;
        if (gameObject.name == "guava")
        {
            guavacount.text = (Game_state.guava - 1).ToString();
            Game_state.guava=Game_state.guava - 1;
        }
        else if (gameObject.name == "apple")
        {
            applecount.text = (Game_state.apple - 1).ToString();
            Game_state.apple = Game_state.apple - 1;
        }
        else if (gameObject.name == "orange")
        {
            orangecount.text = (Game_state.orange - 1).ToString();
            Game_state.orange = Game_state.orange - 1;
        }
        else if (gameObject.name == "watermelon")
        {
            meloncount.text = (Game_state.watermelon - 1).ToString();
            Game_state.watermelon = Game_state.watermelon - 1;
        }
    }
}
