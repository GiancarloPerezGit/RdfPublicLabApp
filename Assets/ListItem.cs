using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ListItem : MonoBehaviour
{
    public string named = "";
    public int maxQuantity = 2;
    public int currentQuantity = 0;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI maxQuantityText;
    public Text currentQuantityText;
    public void infoUpdate()
    {
        nameText.text = named;
        maxQuantityText.text = "Quantity: " + maxQuantity;
        //currentQuantityText.text = "" + currentQuantity;
    }

    public void increaseQuantity()
    {
        
        if(currentQuantity == maxQuantity)
        {
            
        }
        else
        {
            currentQuantity += 1;
            currentQuantityText.text = "" + currentQuantity;
        }
        
    }

    public void decreaseQuantity()
    {

        if (currentQuantity == 0)
        {

        }
        else
        {
            currentQuantity -= 1;
            currentQuantityText.text = "" + currentQuantity;
        }

    }
}
