using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSection
{
    public float lengthInSeconds = 60;//300;
    public float startTime = 19 * 3600;// 7PM       //Used to convert from seconds to AM PM
    public float endTime = 24 * 3600; // Midnight

    private float lengthOfDayTime;
    private float timeMultipler;

    //time = (hour x 3600 + minutes x 60 + seconds ) / 86400. Formula For Time

    public TimeSection()
    {
        lengthOfDayTime = endTime - startTime;
        timeMultipler = lengthOfDayTime / lengthInSeconds;
    }

    public string convertToAMPM(float timeToDisplay)
    {
        var currentTimeChanged = lengthInSeconds - timeToDisplay;
        var multipledTime = currentTimeChanged * timeMultipler;
        //float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        //float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //Debug.Log("MultipliedTime Seconds: " + currentTimeChanged * timeMultipler);
        TimeSpan time = TimeSpan.FromSeconds(multipledTime + startTime);
        int hours = time.Hours;
        int minutes = time.Minutes;
        string timePeriod;
        if (hours > 12)
        {
            hours -= 12;
            timePeriod = "PM";
        }
        else
        {
            timePeriod = "AM";
        }

        //string.Format("{0:00}:{1:00} {}", hours, minutes, timePeriod);
        return $"{hours.ToString("00")}:{minutes.ToString("00")} {timePeriod}";
    }
}
