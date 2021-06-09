using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public bool haveWon = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool edit = false;
        if (haveWon && !edit)
        {
            TimerText.fontSize = 75;
            TimerText.color = Color.green;
            edit = true;
        }
        else if (!haveWon)
            this.TimerText.text = string.Format($"{Mathf.RoundToInt(Time.time / 60)}:{(Time.time % 60).ToString("F2")}");
    }
}
