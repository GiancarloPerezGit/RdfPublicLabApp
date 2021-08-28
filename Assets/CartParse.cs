using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CartParse : MonoBehaviour
{
    // Start is called before the first frame update
    public shoppingcart sc;
    public GameObject itemPrefab;
    public GameObject parent;
    private GameObject tempHolder;
    public GameObject scrollParent;
    void Start()
    {
        try
        {
            sc = GameObject.Find("ShoppingCart").GetComponent<shoppingcart>();
            print("test");
            populate();
        }
        catch(Exception e)
        {

        }
    }

    public void populate()
    {
        print("y");
        foreach(Transform child in scrollParent.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Item t in sc.dict.Values)
        {
            tempHolder = Instantiate(itemPrefab, parent.transform);
            tempHolder.GetComponent<CartItem>().UpdateValues(t.named, t.quantity);
            tempHolder.GetComponent<CartItem>().identifier = t;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
