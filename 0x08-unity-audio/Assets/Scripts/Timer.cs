using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    float elapsedTime;
    private TimeSpan timePlaying;

    public Text FinalTime;

    // Initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        timePlaying = TimeSpan.FromSeconds(elapsedTime);
        string timePlayingStr = timePlaying.ToString("mm':'ss'.'ff");
        TimerText.text = timePlayingStr;
    }

    public void Win()
    {
        // when player touches win flag, finish time is displayed in FinalTime in WinCanvas
        timePlaying = TimeSpan.FromSeconds(elapsedTime);
        string timePlayingStr = timePlaying.ToString("mm':'ss'.'ff");
        FinalTime.text = timePlayingStr;
        GetComponent<Timer>().TimerText.enabled = false;
    }
}
