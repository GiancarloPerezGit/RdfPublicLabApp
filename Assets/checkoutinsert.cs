using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;
using TMPro;
public class checkoutinsert : MonoBehaviour
{
    // Start is called before the first frame update
    public SqlSearchComunicator ssc;
    public string testInsert;
    public string properInsert;
    public shoppingcart sc;
    public TMP_InputField named;
    public TMP_InputField pid;
    public TMP_InputField email;
    public TMP_InputField reason;
    private string time;
    private string tempString;
    void Start()
    {
        try
        {
            sc = GameObject.Find("ShoppingCart").GetComponent<shoppingcart>();
        }
        catch (Exception e)
        {

        }
    }

    public bool scCheck()
    {
        if(sc == null)
        {
            try
            {
                sc = GameObject.Find("ShoppingCart").GetComponent<shoppingcart>();
            }
            catch (Exception e)
            {
                return false;
            }
        }
        return true;
    }

    public void insert()
    {
        if(!scCheck() || sc.dict.Count == 0)
        {

        }
        else
        {
            print("Through");
            if (ssc == null)
            {
                ssc = GameObject.Find("Search").GetComponent<SqlSearchComunicator>();
            }
            properInsert = "user=Test&pid=0202020&email=123@email.com&reason=for testing&training=yesm";
            properInsert = "user="+ named.text + "&pid="+ pid.text + "&email=" + email.text + "&reason=" + reason.text + "&training=yesm";
            time = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            foreach (Item i in sc.dict.Values)
            {
                tempString = "&item_name=" + i.named + "&time_checkout=" + time + "&quantity=" + i.currentQuantity.ToString();
                ssc.insertDB(properInsert + tempString);
            }
            print(properInsert);
            sc.dict = new Dictionary<string, Item>();
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
