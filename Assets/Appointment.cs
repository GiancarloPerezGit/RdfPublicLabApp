using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class Appointment : MonoBehaviour
{
    // Start is called before the first frame update
    public string toolTypeNumber = "Prusa1";
    public SpriteRenderer[] times = new SpriteRenderer[7];
    public Dictionary<DateTime, string> dateStatus = new Dictionary<DateTime, string>();
    public TextMeshProUGUI toolName;

    void Start()
    {
        
    }

    public void changeTool(string nameTool, string typeNumber)
    {
        toolName.text = nameTool;
        //Save tool type and number for the future.
        toolTypeNumber = typeNumber;
        //Clear the dictionary in case the database has been changed since last look
        dateStatus.Clear();
        //Run the database select
        //Ignore all strings not matching the toolTypeNumber
        //Convert remaining strings to Datetime
        //Ignore all Datetimes before current date
        //Save each DateTime and its status in the dateStatus dictionary

        //Use the dictionary in future methods whenever the appointment calendar needs to be populated. If a date/time combination does not have a value in the dictionary
        //then it is available and able to be selected. If it is in the dictionary, then it is not available and its SpriteRenderer should be changed to red.
    }

    public void timeUpdate(DateTime selectedDay)
    {
        string day = selectedDay.ToString("dd");
        string month = selectedDay.ToString("MM");
        string time = "10:00 AM";
        DateTime testDate = DateTime.Parse(month + "/" + day + " " + time);

        print(testDate.ToString("G"));
        for (int i = 0; i < 8; i++)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
