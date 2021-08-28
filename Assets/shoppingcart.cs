using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoppingcart : MonoBehaviour
{
    
    public List<Item> cart = new List<Item>();
    public Dictionary<string, Item> dict = new Dictionary<string, Item>();
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (GameObject.FindGameObjectsWithTag("ShoppingCart").Length > 1)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void add(Item i)
    {
        if(dict.ContainsKey(i.named))
        {
            print(i.named);
            dict.Remove(i.named);
        }
        else
        {
            dict.Add(i.named, i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Item
{
    public string named;
    public int quantity;
    public int currentQuantity = 1;

    public Item(string namedV, int quantityV)
    {
        named = namedV;
        quantity = quantityV;
    }
}