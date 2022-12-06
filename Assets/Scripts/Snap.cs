using UnityEngine;
using UnityEngine.EventSystems;

public class Snap : MonoBehaviour, IDropHandler
{
    public float x_position;
    public static Snap Instance;
    [SerializeField] GameObject cat;
    public int speed = 10;
    public bool dropped = false;
    public Vector2 position;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            dropped = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2(transform.position.x + 1, transform.position.y);
    }
    // Update is called once per frame
    void Update()
    {
        if (dropped)
        {
            MoveCat();
        }
    }
    //This method is used to move the rabbit toward the fruit
    public void MoveCat()
    {
        cat.transform.position = Vector2.MoveTowards(cat.transform.position, position, speed * Time.deltaTime);
        Destroy(gameObject, 7);
        
    }
}
