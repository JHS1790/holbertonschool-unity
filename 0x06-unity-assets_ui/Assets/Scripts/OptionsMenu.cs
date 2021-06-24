using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class OptionsMenu : MonoBehaviour
{
    public bool isInverted;
    public Toggle YToggle;

    public bool startCatch = false;

    public void Start()
    {
        if (PlayerPrefs.GetInt("isInverted") == 1)
        {
            isInverted = true;
            YToggle.isOn = true;
        }
        else
        {
            isInverted = false;
            YToggle.isOn = false;
        }
        startCatch = true;
    }

    public void Back()
    {
        Time.timeScale = 1;
        string sceneName = PlayerPrefs.GetString("lastLoadedScene");
        SceneManager.LoadScene(sceneName);
    }

    public void ToggleY()
    {
        if(startCatch)
            isInverted = !isInverted;
    }

    public void Apply()
    {
        if (isInverted)
        {
            PlayerPrefs.SetInt("isInverted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("isInverted", 0);

        }
        this.Back();
    }
}
