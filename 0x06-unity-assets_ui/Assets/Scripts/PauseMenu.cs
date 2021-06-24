using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    static Scene returnscene;
    public GameObject MenuCanvas; 
    
    public void Start()
    {
        returnscene = SceneManager.GetActiveScene();
        PlayerPrefs.SetString ("lastLoadedScene", returnscene.name);
    }
    void Update()
    {
        if (Input.GetKey("escape"))
            Pause();
    }
    public void Pause()
    {
        Time.timeScale = 0;
        MenuCanvas.gameObject.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        MenuCanvas.gameObject.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        PlayerPrefs.SetString ("lastLoadedScene", returnscene.name);
        SceneManager.LoadScene("Options");
    }
}
