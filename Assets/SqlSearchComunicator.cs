using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SqlSearchComunicator : MonoBehaviour
{
    private string secretKey = "";
    public string searchURL = "http://rdflabpiserver/sql/select.php";
    public string checkoutInsertUrl = "http://rdfdatabase1.cs.fiu.edu/co_insert.php?";
    private string test = "http://google.com";

    public string results = "";
    public string[] dbItems;
    public int searching;
    public DatabaseManager dm;
    private GameObject go;
    void Awake()
    {
        //Debug.Log("search query: get results");
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        if(GameObject.FindGameObjectsWithTag("Search").Length > 1)
        {
            Destroy(this.gameObject);
        }
        //StartCoroutine(GetResults());
    }
    
    public void pullDB()
    {
        StartCoroutine(GetResults());
    }
    
    public void insertDB(string insert)
    {
        StartCoroutine(insertCheckout(insert));
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        go = GameObject.Find("StartSearch");
        if (go != null)
        {
            dm = go.GetComponent<DatabaseManager>();
            if(dm.start)
            {
                StartCoroutine(GetResults());
            }
        }
        
    }



    public IEnumerator insertCheckout(string insert)
    {
        searching = 0;
        //Debug.Log("search query: start query to: " + searchURL);
        UnityWebRequest results_get = UnityWebRequest.Get(checkoutInsertUrl + insert);
        print(checkoutInsertUrl + insert);
        yield return results_get.SendWebRequest();

        if (results_get.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("insert query: there was an error..." + results_get.error);
            searching = 1;
        }
        else
        {
            results = results_get.downloadHandler.text;
            searching = 2;
        }
        print("finished");
        //dbItems = results.Split(new[] { "<br>" }, StringSplitOptions.None);
        //dm.Populate(dbItems);
    }

    public IEnumerator GetResults ()
    {
        searching = 0;
        //Debug.Log("search query: start query to: " + searchURL);
        UnityWebRequest results_get = UnityWebRequest.Get(searchURL);

        yield return results_get.SendWebRequest();
        
        if (results_get.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("search query: there was an error..." + results_get.error);
            searching = 1;
        }
        else
        {
            results = results_get.downloadHandler.text;
            searching = 2;
        }
        dbItems = results.Split(new[] { "<br>" }, StringSplitOptions.None);
        dm.Populate(dbItems);
    }

}
