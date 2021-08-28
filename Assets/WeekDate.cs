using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class WeekDate : MonoBehaviour
{
    public double dateOffset;
    public TextMeshProUGUI text;
    public DateTime dt;
    public Appointment app;
    // Start is called before the first frame update
    void Start()
    {
        dateUpdate();   
    }

    public void dateUpdate()
    {
        DateTime today = DateTime.Now;
        string day = today.AddDays(dateOffset).ToString("dd");
        string month = today.AddDays(dateOffset).ToString("MM");
        text.text = month + "/" + day;
        dt = DateTime.Parse(text.text);
        print(dt.ToString("G"));
        //app.timeUpdate(dt);
    }
    
    public void subtractDate()
    {
        if(dateOffset == 0)
        {

        }
        else
        {
            dateOffset -= 5;
            dateUpdate();
        }
    }
}
