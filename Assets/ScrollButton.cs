using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScrollButton : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public ScrollRect scrollRect;
    public bool movin = false;
    public shoppingcart sc;
    public CartItem ci;
    private bool clicked = false;
    public void OnBeginDrag(PointerEventData eventData)
    {
        movin = true;
        ExecuteEvents.Execute(scrollRect.gameObject, eventData, ExecuteEvents.beginDragHandler);
    }

    public void OnDrag(PointerEventData eventData)
    {
        ExecuteEvents.Execute(scrollRect.gameObject, eventData, ExecuteEvents.dragHandler);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ExecuteEvents.Execute(scrollRect.gameObject, eventData, ExecuteEvents.endDragHandler);
    }

    public void up(string scene)
    {
        if(movin == true)
        {
            movin = false;
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
    }

    public void checkoutUp()
    {
        if(movin == true)
        {
            movin = false;
        }
        else
        {         
            sc.add(new Item(this.gameObject.GetComponent<ListItem>().named, this.gameObject.GetComponent<ListItem>().maxQuantity));  
        }
    }

    public void checkoutIncrease()
    {
        if(movin == true)
        {
            movin = false;
        }
        else
        {
            ci.IncreaseQuantity();
        }
    }

    public void checkoutDecrease()
    {
        if (movin == true)
        {
            movin = false;
        }
        else
        {
            ci.DecreaseQuantity();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
