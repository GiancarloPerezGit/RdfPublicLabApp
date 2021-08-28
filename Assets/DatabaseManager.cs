using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
public class DatabaseManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject prefab;
    public GameObject parent;
    public ScrollRect scrollRect;
    public shoppingcart sc;
    public SqlSearchComunicator ssc;
    public bool start = true;
    public bool populated = false;
    private string newString;
    void Start()
    {
        
        //choice.GetComponent<SqlSearchComunicator>().pullDB();
    }
    private void OnEnable()
    {
        ssc = GameObject.Find("Search").GetComponent<SqlSearchComunicator>();
        sc = GameObject.Find("ShoppingCart").GetComponent<shoppingcart>();
        newString = ssc.searchURL;
        print(newString);
    }
    public void Populate(string[] list)
    {
        populated = true;
        ssc.searchURL = newString;
        foreach(GameObject g in GameObject.FindGameObjectsWithTag("ListItem"))
        {
            Destroy(g);
        }
        
        for(int i = 0; i < list.Length -1; i++)
        {
            GameObject child = Instantiate(prefab, parent.transform);
            child.GetComponent<ScrollButton>().scrollRect = scrollRect;
            child.GetComponent<ScrollButton>().sc = sc;

            //child.transform.parent = parent.transform;
            //child.transform.SetParent(parent.transform);
            string[] namequant = list[i].Split(new[] { "~" }, StringSplitOptions.None);
            print(namequant[0]);
            print(namequant[1]);
            child.GetComponent<ListItem>().named = namequant[0];
            child.GetComponent<ListItem>().maxQuantity = int.Parse(namequant[1]);
            child.GetComponent<ListItem>().infoUpdate();
        }
    }

    public void Search(TMP_InputField ti)
    {
        //newString = ssc.searchURL;
        ssc.searchURL += ti.text;
        ssc.pullDB();
    }

    // Update is called once per frame
    void Update()
    {
        //while(choice.GetComponent<SqlSearchComunicator>().searching == 0)
        //{
        //    print("Hello");
        //}
        //if(choice.GetComponent<SqlSearchComunicator>().searching == 1)
        //{

        //}
        //else if(!populated && choice.GetComponent<SqlSearchComunicator>().searching == 2)
        //{
        //    Populate(choice.GetComponent<SqlSearchComunicator>().dbItems);
        //}
    }
}
