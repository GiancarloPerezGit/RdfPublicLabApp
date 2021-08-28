using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrintChange : MonoBehaviour
{
    // Start is called before the first frame update
    public ScrollRect sc;
    void Start()
    {
        sc.onValueChanged.AddListener(printVal);
    }

    public void printVal(Vector2 val)
    {
        print(val);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
