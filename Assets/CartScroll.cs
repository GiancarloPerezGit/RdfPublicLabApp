using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CartScroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<ScrollButton>().scrollRect = GameObject.FindGameObjectWithTag("ScrollParent").GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
