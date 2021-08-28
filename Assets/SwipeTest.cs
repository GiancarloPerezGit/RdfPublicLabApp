using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    // Start is called before the first frame update
    public int pageNum = 1;
    public int pageMax = 3;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public CartParse pc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void swipeDetector(Vector3 dir)
    {
        if(dir.x < 0 && Mathf.Abs(dir.x) > Mathf.Abs(dir.y) && pageNum != pageMax)
        {
            print("Right");
            pageNum += 1;
        }
        else if(dir.x > 0 && Mathf.Abs(dir.x) > Mathf.Abs(dir.y) && pageNum != 1)
        {
            print("Left");
            pageNum -= 1;
        }
        if(pageNum == 1)
        {
            page1.transform.position = new Vector3(0, 0, 0);
            page2.transform.position = new Vector3(10, 0, 0);
            page3.transform.position = new Vector3(20, 0, 0);

        }
        else if(pageNum == 2)
        {
            page1.transform.position = new Vector3(-10, 0, 0);
            page2.transform.position = new Vector3(0, 0, 0);
            page3.transform.position = new Vector3(10, 0, 0);
        }
        else if (pageNum == 3)
        {
            page1.transform.position = new Vector3(-20, 0, 0);
            page2.transform.position = new Vector3(10, 0, 0);
            page3.transform.position = new Vector3(0, 0, 0);
            if(pc != null)
            {
                pc.populate();
            }
            
        }
    }
    public void test()
    {

    }
}
