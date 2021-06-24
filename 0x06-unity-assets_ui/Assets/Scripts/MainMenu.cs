using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    static Scene returnscene;

    public void LevelSelect(int level)
    {
        SceneManager.LoadScene("Level0" + level);
    }

    public void Start()
    {
        returnscene = SceneManager.GetActiveScene();
        PlayerPrefs.SetString ("lastLoadedScene", returnscene.name);
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
