using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndEvents : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;

    public event EventHandler rewardHandler;

    private bool stopTimer;
    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(time);
        int milliseconds = Mathf.FloorToInt(time * 10 - seconds * 10);

        string textTime = string.Format("{0:0}.{1:0}", seconds, milliseconds);

        if (time <= 0)
        {
            stopTimer = true;
        }
        if (stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;
        }
        else
        {

        }

    }
}