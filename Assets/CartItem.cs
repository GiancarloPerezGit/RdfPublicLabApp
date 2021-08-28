using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using System;
public class CartItem : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI currentQuantity;
    public int maxQuantity;
    public int currentQuantityInt = 1;
    public Item identifier;
    // Start is called before the first frame update
    void Start()
    {
        currentQuantity.text = "1";
    }

    public void UpdateValues(string Name, int Quantity)
    {
        nameText.text = Name;
        maxQuantity = Quantity;
    }

    public void IncreaseQuantity()
    {
        if(currentQuantityInt >= maxQuantity)
        {
            currentQuantityInt = maxQuantity;
        }
        else
        {
            currentQuantityInt += 1;
            currentQuantity.text = currentQuantityInt.ToString();
        }
        identifier.currentQuantity = currentQuantityInt;
    }

    public void DecreaseQuantity()
    {
        if (currentQuantityInt <= 0)
        {
            currentQuantityInt = 0;
        }
        else
        {
            currentQuantityInt -= 1;
            currentQuantity.text = currentQuantityInt.ToString();
        }
        identifier.currentQuantity = currentQuantityInt;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
