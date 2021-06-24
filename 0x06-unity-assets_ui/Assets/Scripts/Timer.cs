using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject WinCanvas;
    public Text TimerText;
    public Text WinTimeText;
    float startTime;
    float elapsedTime;
    public bool haveWon = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;
        bool edit = false;
        if (haveWon && !edit)
        {
            Time.timeScale = 0;
            TimerText.fontSize = 75;
            TimerText.color = Color.clear;
            edit = true;
            Win();
        }
        else if (!haveWon)
            this.TimerText.text = string.Format($"{Mathf.RoundToInt(elapsedTime / 60)}:{(elapsedTime % 60).ToString("F2")}");
    }

    public void Win()
    {
        WinCanvas.gameObject.SetActive(true);
        WinTimeText.text = string.Format($"{Mathf.RoundToInt(elapsedTime / 60)}:{(elapsedTime % 60).ToString("F2")}");
    }
}
