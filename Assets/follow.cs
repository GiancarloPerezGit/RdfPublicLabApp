using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject parent;
    private Vector3 lco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(parent.transform.position);
        lco = this.gameObject.transform.position;
        lco.x = parent.gameObject.transform.position.x;
        this.gameObject.transform.position = lco;
    }
}
